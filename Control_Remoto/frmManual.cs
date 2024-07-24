using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using DigitalIO;
using ErrorDefs;
using MccDaq;
using EasyModbus;
using System.Threading;

namespace Control_Remoto
{
    public partial class frmManual : Form
    {
        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");
        Sistema_Vision main = new Sistema_Vision();
        TCP_IP camAspirina = new TCP_IP(23);
        int m, mx, my;
        ModbusClient motor1 = new ModbusClient();
        ModbusClient motor2 = new ModbusClient();
        ModbusClient motor3 = new ModbusClient();
        int addPosH = 25090; //Direcciones segun el documento oficial de motor leadshine iCS-RS series (se aumenta uno al que se indica y se pone en enteros decimales)
        int addPosL = 25091;
        int addVel = 25092;
        int addMov = 25579;
        int addDir = 8; // La direccion se indica en el address 0007, se aumenta uno como los demas
        //Variables para guardar valores de posicion, velocidad y orden de movimiento del motor
        int position1, position2, velocity, movOrder, rotaryDir;

        #region funcionesBasicas
        public frmManual()
        {
            InitializeComponent();
        }
        private void frmManual_Load(object sender, EventArgs e)
        {
            try
            {
                //Configuracion y conexion de motores
                //Motor 1
                motor1.SerialPort = IniSettings.IniReadValue("Motor1", "Port");
                motor1.Baudrate = int.Parse(IniSettings.IniReadValue("Motor1", "Baud"));
                motor1.Parity = Parity.None;
                motor1.Connect();
                //Motor 2
                motor2.SerialPort = IniSettings.IniReadValue("Motor2", "Port");
                motor2.Baudrate = int.Parse(IniSettings.IniReadValue("Motor2", "Baud"));
                motor2.Parity = Parity.None;
                motor2.Connect();
                //Motor 3
                motor3.SerialPort = IniSettings.IniReadValue("Motor3", "Port");
                motor3.Baudrate = int.Parse(IniSettings.IniReadValue("Motor3", "Baud"));
                motor3.Parity = Parity.None;
                motor3.Connect();
            }
            catch
            {

            }
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            Mantenimiento models = new Mantenimiento();
            models.Show();
            this.Close();
        }

        private void btnIOVIEWER_Click(object sender, EventArgs e)
        {
            //Abrir ventana nueva de Mantenimiento IOViewer
            IOViewer iov = new IOViewer();
            iov.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Parametros config = new Parametros();
            config.Show();
            this.Close();
        }

        private void btnMove1_Click(object sender, EventArgs e)
        {
            moveMotor(tbMicro1.Text,tbVel1.Text,cbDir1.Text, motor1);
        }

        private void btnMove2_Click(object sender, EventArgs e)
        {
            moveMotor(tbMicro2.Text, tbVel2.Text,cbDir2.Text, motor2);
        }

        private void btnReadAngle_Click(object sender, EventArgs e)
        {
            camAspirina.Conectar(IniSettings.IniReadValue("CamaraAspirina", "IP"));
            if (camAspirina.conectado)
            {
                try
                {
                    string basura, angulo;
                    LoginAspirina();
                    basura = camAspirina.Leer(); //Para quitar elementos basura que tenga sensor en la primera lectura
                    TriggerAspirina();
                    angulo = camAspirina.EnviarComando("GVOutput" + (char)13 + (char)10);  //Comando para obtener resultado de la herramienta Math_1 celda A0//Cambio con nueva camara D905 a GVOutput
                    tbAngulo.Text = angulo;
                }
                catch { MessageBox.Show("Error de lectura o comando en cámara de la Aspirina", "ERROR DE DISPOSITIVO"); }
               

            }
            else
            {
                MessageBox.Show("Error al conectar Camara de la Aspirina", "ERROR DE DISPOSITIVO");
            }

        }

        private void btnMove3_Click(object sender, EventArgs e)
        {
            moveMotor(tbMicro3.Text, tbVel3.Text,cbDir3.Text, motor3);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void frmManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["Mantenimiento"] == null && Application.OpenForms["IOViewer"] == null && Application.OpenForms["Parametros"] == null)
            {
                main.Visible = true;               
            }
        }
        #endregion

        #region FuncionesPrincipales
        public void moveMotor(string microposition, string velocidad, string dir, ModbusClient selectmotor)
        {
            if (microposition == "" && velocidad == "")
            {
                MessageBox.Show("ERROR: Favor de especificar velocidad y posicion de movimiento");
            }
            else
            {
                position1 = int.Parse(microposition);
                velocity = int.Parse(velocidad);
                position2 = 0; //Posicion que va en High
                movOrder = 10; //valor de comando para mover
                rotaryDir = int.Parse(dir);
                string hexposition = decimalHexadecimal(position1); //Para conseguir valor en hexadecimal de la posicion
                string hexaposition2;
                if (position1 > 65535) //Si el valor en entero decimal sobrepasa el 65535 cambia a 5 caracteres en hexadecimal, hay que dividirlo en position 1 y position 2
                {
                    hexaposition2 = hexposition.Substring(0, 1);
                    hexposition = hexposition.Substring(1, 4);

                    position2 = hexadecimalDecimal(hexaposition2);
                    position1 = hexadecimalDecimal(hexposition);
                }
                selectmotor.WriteSingleRegister(addPosH, position2);
                selectmotor.WriteSingleRegister(addPosL, position1);
                selectmotor.WriteSingleRegister(addVel, velocity);
                selectmotor.WriteSingleRegister(addDir, rotaryDir);//Agregado para definir direccion de movimiento.
                Thread.Sleep(200);
                selectmotor.WriteSingleRegister(addMov, movOrder);
            }
            
        }

        public static String decimalHexadecimal(int numero)
        {

            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };

            String hexadecimal = "";

            const int DIVISOR = 16;
            long resto = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                resto = i % DIVISOR;
                if (resto >= 10)
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;

                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }


            return hexadecimal;

        }
        public static int hexadecimalDecimal(String hexadecimal)
        {

            int numero = 0;

            const int DIVISOR = 16;

            for (int i = 0, j = hexadecimal.Length - 1; i < hexadecimal.Length; i++, j--)
            {

                if (hexadecimal[i] >= '0' && hexadecimal[i] <= '9')
                {
                    numero += (int)Math.Pow(DIVISOR, j) * Convert.ToInt32(hexadecimal[i] + "");
                }
                else if (hexadecimal[i] >= 'A' && hexadecimal[i] <= 'F')
                {
                    numero += (int)Math.Pow(DIVISOR, j) * Convert.ToInt32((hexadecimal[i] - 'A' + 10) + "");
                }
                else
                {
                    return -1;
                }

            }

            return numero;

        }

        public void LoginAspirina()
        {
            /*Login*/
            //Leer mensaje de bienvenida
            string respuestaTemp = camAspirina.Leer();
            //Introducir usuario
            respuestaTemp = camAspirina.EnviarComando("admin" + (char)13 + (char)10 + " \n");
            //Introducir contraseña
            respuestaTemp = camAspirina.EnviarComando("" + (char)13 + (char)10 + " \n");

            //Verificar que no se quedo ningun dato sin leer
            respuestaTemp = camAspirina.Leer();
        }

        public void TriggerAspirina()
        {
            camAspirina.EnviarComandoSinRespuesta("MT" + (char)13 + (char)10);
        }

        #endregion
    }
}
