using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using TamuseFunctions;
using System.IO;
using System.Threading;

namespace Control_Remoto
{

    public partial class IOViewer : Form
    {
        int m, mx, my;
        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");
        Sistema_Vision main = new Sistema_Vision();
        ModbusClient PLC = new ModbusClient(); //Creacion del cliente modbus (PLC)
        Thread reviewPlc;
        public IOViewer()
        {
            InitializeComponent();
        }

        private void IOViewer_Load(object sender, EventArgs e)
        {

        }

        private void IOViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verificar si otras ventanas de mantenimiento estan abiertas
            if (Application.OpenForms["Mantenimiento"] == null && Application.OpenForms["Parametros"] == null && Application.OpenForms["frmManual"]== null)
            {
                main.Visible = true;
            }
        }

        #region funcionesVentana
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnIOVIEWER_Click(object sender, EventArgs e)
        {
            //No hago nada, ya estoy en IOViewer
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            Mantenimiento models = new Mantenimiento();
            models.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Parametros config = new Parametros();
            config.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            PLC.IPAddress = IniSettings.IniReadValue("PLC", "IP");
            try
            {
                PLC.Connect(); //Trata de conectar al PLC (despues de haber guardado el IP)
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (PLC.Connected == true)
            {
                lblStatus.Text = "A\nC\nT\nI\nV\nO";
                lblStatus.BackColor = Color.LightGreen;
                pictureBox1.BackColor = Color.LightGreen;
                //Crear hilo para verificacion de IO en todo momento
                reviewPlc = new Thread(verifyIO);
                reviewPlc.IsBackground = true;
                reviewPlc.Start();
            }

        }

        private void btnDisconect_Click(object sender, EventArgs e)
        {
            PLC.Disconnect();
            lblStatus.Text = "I\nN\nA\nC\nT\nI\nV\nO";
            lblStatus.BackColor = Color.Gray;
            pictureBox1.BackColor = Color.Gray;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(14, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(14, true);
                    btnS1.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(14, false);
                    btnS1.BackColor = Color.Gray;
                }
            }
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(15, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(15, true);
                    btnS2.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(15, false);
                    btnS2.BackColor = Color.Gray;
                }
            }
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(16, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(16, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(16, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS4_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(17, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(17, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(17, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(18, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(18, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(18, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS6_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(19, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(19, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(19, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(20, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(20, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(20, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS8_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(21, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(21, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(21, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS9_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(22, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(22, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(22, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS10_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(23, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(23, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(23, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS11_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(24, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(24, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(24, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS12_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(25, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(25, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(25, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS13_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(26, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(26, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(26, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnS14_Click(object sender, EventArgs e)
        {
            if (PLC.Connected)
            {
                bool[] res0 = PLC.ReadCoils(27, 1);
                if (!res0[0])
                {
                    PLC.WriteSingleCoil(27, true);
                    btnS3.BackColor = Color.LightGreen;
                }
                else
                {
                    PLC.WriteSingleCoil(27, false);
                    btnS3.BackColor = Color.Gray;
                }
            }
        }

        private void btnManejo_Click(object sender, EventArgs e)
        {
            //Abrir ventana nueva de Mantenimiento Manejo manual
            frmManual manual = new frmManual();
            manual.Show();
            this.Close();
        }

        private void verifyIO()
        {
            while(PLC.Connected)
            {
                bool[] resultado;
                resultado = PLC.ReadCoils(0, 14); //Funcion para leer los boleanos de las direcciones del PLC (Posicion de la primera direccion y cantidad de elementos a leer)

                //Revisión de entradas PLC
                for (int i = 0; i <= 13; i++){ //recorre 14 entradas
                    if (resultado[i]) //Verifica si la entrada esta activa
                    {
                        //colorfunc(i,true);
                        this.Invoke(new Action(() => colorfunc(i,true)));
                    }
                    else
                    {
                        //colorfunc(i, false);
                        this.Invoke(new Action(() => colorfunc(i, false)));
                    }
                }
            }
        }

        private void colorfunc(int indice, bool entrada)
        {
            //Hecho para 14 entradas, se debe modificar si se requiere
            switch (indice)
            {
                case 0:
                    {
                        if (entrada)
                        {
                            lblE1.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE1.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 1:
                    {
                        if (entrada)
                        {
                            lblE2.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE2.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 2:
                    {
                        if (entrada)
                        {
                            lblE3.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE3.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 3:
                    {
                        if (entrada)
                        {
                            lblE4.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE4.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 4:
                    {
                        if (entrada)
                        {
                            lblE5.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE5.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 5:
                    {
                        if (entrada)
                        {
                            lblE6.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE6.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 6:
                    {
                        if (entrada)
                        {
                            lblE7.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE7.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 7:
                    {
                        if (entrada)
                        {
                            lblE8.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE8.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 8:
                    {
                        if (entrada)
                        {
                            lblE9.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE9.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 9:
                    {
                        if (entrada)
                        {
                            lblE10.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE10.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 10:
                    {
                        if (entrada)
                        {
                            lblE11.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE11.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 11:
                    {
                        if (entrada)
                        {
                            lblE12.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE12.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 12:
                    {
                        if (entrada)
                        {
                            lblE13.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE13.BackColor = Color.Gray;
                        }
                        break;
                    }
                case 13:
                    {
                        if (entrada)
                        {
                            lblE14.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            lblE14.BackColor = Color.Gray;
                        }
                        break;
                    }
            }
        }
       
        #endregion



    }
}
