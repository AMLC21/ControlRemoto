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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using ModbusTCP;
using System.Net;
using System.Net.Sockets;
using TamuseFunctions;
using IniFile;
using DigitalIO;
using MccDaq;
using ErrorDefs;
using GRABCYC;
using EasyModbus;
using System.Globalization;

namespace Control_Remoto
{
    public partial class Sistema_Vision : Form
    {
        #region variables             
        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");
        public static string dbDir = Directory.GetCurrentDirectory() + "\\Settings\\Modelos.csv";
        public string operador;//Para almacenar el numero de operador
        public string activeScanOp; //Para ver si desea activar la verificacion de operador por escaner
        public string dia, semana, mes, year;
        int m, mx, my;//Para movimiento de ventana
        string modelo = "";
        public bool pieza_correcta = false;
        public bool programaIniciado = false;
        public int pzas_correctas = 0;
        public int pzas_incorrectas = 0;
        public int pzas_totales = 0;
        public string estatusPieza = "";
        private Thread seqPrincipal;
        private Thread cortinas;
        ModbusClient PLC = new ModbusClient(); //Para manejo de PLC
        public bool devicesReady=false;
        public string fails;
        public float yield;
        public bool liberado=true;

        int mm, ss;

        //Constantes para numero de entradas y salidas (DIO/PLC)
        //Entradas/Inputs

        //Salidas/Outputs
        public const int O_lampVerde = 15; //Torreta color verde
        public const int O_lampRoja = 16; //Torreta color rojo
        public const int O_lampAmar = 17; //Torreta color amarillo
        public const int O_lampAzul = 18; //Torreta color azul

        TCP_IP camaraAspirina = new TCP_IP(23); //Para camara de verificacion Aspirina
        float anguloAspirina;

        #endregion

        #region Funciones_ventana
        public Sistema_Vision()
        {
            InitializeComponent();

        }
        private void Sistema_Vision_Load(object sender, EventArgs e)
        {
            //Verificacion del operador
            activeScanOp = IniSettings.IniReadValue("EscanerOp", "activo");
            operador = IniSettings.IniReadValue("EscanerOp", "lastoper");
            if (activeScanOp == "Si"&& operador=="No_Operador")
            {
                frmOperador foper = new frmOperador();
                foper.ShowDialog();
               
            }
            operador= IniSettings.IniReadValue("EscanerOp", "lastoper");
            lblOperador.Text = "Operador: "+ operador;          


            //Asignar IP a PLC
            PLC.IPAddress = IniSettings.IniReadValue("PLC", "IP");
        }

        private void Sistema_Vision_FormClosing(object sender, FormClosingEventArgs e)
        {
            IniSettings.IniWriteValue("EscanerOp", "lastoper", "No_Operador"); //Para "Deslogear" al operador activo
        }

        private void btn_iniciar_detener_Click(object sender, EventArgs e)//Click en iniciar
        {
            try
            {
                if (!programaIniciado)//Si programa no ha sido iniciado (Acciones para boton iniciar)
                {
                    cb_modelo.Enabled = false;
                    if(modelo != ""||modelo != null)
                    {
                        programaIniciado = true;
                        btn_iniciar_detener.BackgroundImage = Properties.Resources.button_detener;

                        //Verificar conexion de dispositivos
                        verifydevices();
                        if (devicesReady)
                        {
                            StartCron();
                            //Iniciar hilo de secuencia de prueba
                            seqPrincipal = new Thread(MainSecuence);
                            seqPrincipal.Start();
                            
                        }


                    }//Fin de la verificacion si hay modelo seleccionado
                    else
                    {
                        MessageBox.Show("FAVOR DE SELECCIONAR UN MODELO");
                    }

                }//Fin de la verificion programa iniciado
                else if(programaIniciado) // Acciones para Boton detener
                {
                    cb_modelo.Enabled = true;
                    btn_iniciar_detener.BackgroundImage = Properties.Resources.button_iniciar;
                    programaIniciado = false;
                    closedevices();
                    seqPrincipal.Abort();
                    
                }
            }
            catch { }           

        }     
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)//Evento que ocurre al dar click en el boton de Mantenimiento del menú
        {           
            Password acceso = new Password();
            if (acceso.ShowDialog() == DialogResult.OK)//Verifica si puso contraseña correcta para entrar a la opcion mantenimiento
            {
                this.Visible = false;//Este comando oculta el form principal para que solo se muestren los forms de mantenimiento
                Mantenimiento mant = new Mantenimiento();
                mant.Show();                
            }            
                                 
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        
        private void cb_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_modelo.Text != "")
            {
                modelo = cb_modelo.Text;
                btn_iniciar_detener.Enabled = true;
            }
        }

        private void btnCalidad_Click(object sender, EventArgs e)
        {
            Password_Calidad passcali = new Password_Calidad();
            if (passcali.ShowDialog() == DialogResult.OK)
            {
                //this.Visible = false;
                frmCalidad cali = new frmCalidad();
                cali.Show();
            }
                       
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmInfo info = new frmInfo();
            info.Show();
            //FuncionPass();
        }

        private void btnChangeOper_Click(object sender, EventArgs e)
        {
            if (activeScanOp == "Si")
            {
                frmOperador foper = new frmOperador();
                foper.ShowDialog();
                operador = IniSettings.IniReadValue("EscanerOp", "lastoper");
                lblOperador.Text = "Operador: " + operador;
            }
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if(m==1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void btnGrayModel_Click(object sender, EventArgs e)
        {
            if (btnGrayModel.Text == "Modelo Gris")
            {
                cb_modelo.Visible = true;
                lb_modelo.Visible = true;
                btnBlackModel.Visible = false;                
                CargaCombo("Gris");
                btnGrayModel.Text = "REGRESAR";
            }
            else
            {
                cb_modelo.Visible = false;
                lb_modelo.Visible = false;
                btnBlackModel.Visible = true;
                btnGrayModel.Text = "Modelo Gris";
            }

        }
        private void btnBlackModel_Click(object sender, EventArgs e)
        {
            if (btnBlackModel.Text == "Modelo Negro")
            {
                cb_modelo.Visible = true;
                lb_modelo.Visible = true;
                btnGrayModel.Visible = false;
                CargaCombo("Negro");
                btnBlackModel.Text = "REGRESAR";
            }
            else
            {
                cb_modelo.Visible = false;
                lb_modelo.Visible = false;
                btnGrayModel.Visible = true;
                btnBlackModel.Text = "Modelo Negro";
            }
        }


        #endregion

        #region OtrasFunciones

        private void CargaCombo(string colormodelo)
        {
            //Carga listado de modelos al combo box cb_modelos
            List<String> mods = new List<String>();
            mods.Add("");//linea en blanco para el inicio
            string[] list = File.ReadAllLines(dbDir); //leer contenido del archivo por lineas

            for (int i = 1; i < list.Length; i++)
            {
                string[] vals = list[i].Split(',');

                if (colormodelo == vals[2])
                {
                    mods.Add(vals[0] + "_" + vals[1]);
                }
               
            }

            cb_modelo.DataSource = mods;
        }

        #endregion

        #region funcionesMain

        #region resultados
        public void imprimir_etiqueta() //Para imprimir la etiqueta
        {
            try
            {
                IniFile.Ini settings = IniSettings;
                string impresora = settings.IniReadValue("Impresora", "Nombre");
                StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Settings\\" + "\\label.txt"); //Direccion del template de la etiqueta
                string label = reader.ReadToEnd();
                label = label.Replace("MODELO", cb_modelo.Text);
                label = label.Replace("FECHA", DateTime.Now.ToString("MM/dd/yyyy"));
                label = label.Replace("HORA", DateTime.Now.ToString("HH:mm:ss tt"));
                RawPrinterHelper.SendStringToPrinter(impresora, label);
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Error al imprimir etiqueta", "Error");
            }
        }
        public void resultReport(string modelo, string oper, string result, string fallo) //Para ingresar los resultados a los reportes
        {
            //Creamos variables que guardan el dia, el mes y el año actuales
            dia = DateTime.Now.Day.ToString();
            mes = DateTime.Now.ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));
            year = DateTime.Now.Year.ToString();
            semana = numeroSemana(DateTime.Now).ToString();
            try
            {
                if (!Directory.Exists(@"c:\Reportes"))//Si no existe la carpeta de Reportes hay que crearla
                {
                    DirectoryInfo di = Directory.CreateDirectory(@"c:\Reportes");
                }
                if (!Directory.Exists(@"c:\Reportes\" + mes + "_" + year)) //Si no existe el reporte del mes actual hay que crear uno nuevo
                {
                    DirectoryInfo di = Directory.CreateDirectory(@"c:\Reportes\" + mes + "_" + year);
                }

                //Creamos la ruta al archivo csv donde se guardarán los datos del día
                string strFilePath = @"c:\Reportes\" + mes + "_" + year + "\\" + dia + "_" + mes + "_" + year + "_" + semana + ".csv";

                if (!File.Exists(strFilePath)) //Si no existe el archivo csv correspondiente al dia actual se crea el archivo
                {
                    string columnas = "MODELO,FECHA_PRUEBA,HORA_PRUEBA,OPERADOR,ESTATUS,FALLA \r\n"; //Encabezados del csv, los caracteres de retorno de carro y salto de linea se ponen para que la informacion siguiente se ponga siempre debajo en una linea nueva
                    File.AppendAllText(strFilePath, columnas); //Creamos archivo en la ruta strFilePath con el contenido de la variable columnas
                }

                //Guardado del registro de la prueba actual al archivo
                string fechaFull = DateTime.Now.ToString("yyyy-MM-dd");
                string horaActual = DateTime.Now.ToString("HH:mm:ss");
                string registro = modelo + "," + fechaFull + "," + horaActual + "," + operador + "," + result + "," + fallo + "\n";
                File.AppendAllText(strFilePath, registro);

            }
            catch { }



        }
        public void FuncionPass()
        {
            panel1.BackColor = Color.Green;
            lblMessage.Text = "PIEZA CORRECTA";
        }
        public void FuncionFail()
        {
            panel1.BackColor = Color.Red;
            lblMessage.Text = "PIEZA INCORRECTA";
            Password_Calidad passcali = new Password_Calidad();
            desbloqueoCalidad:
            if (passcali.ShowDialog() == DialogResult.OK)
            {
                LiberarPieza(); //Esta funcion debe hacer que la maquina termine y libere la pieza.
            }
            else
            {
                goto desbloqueoCalidad;
            }

        }

        public void LoadCount() //Para actualizar conteo de piezas buenas y malas
        {
            ObtainDayResults(dia, mes, year, modelo, semana);
            lb_conta_correctas.Text = pzas_correctas.ToString();
            lb_conta_incorrectas.Text = pzas_incorrectas.ToString();
            pzas_totales = pzas_correctas + pzas_incorrectas;
            lblPorcentajeRendimiento.Text = RendimientoYield();

           // chrtRendimiento.Series.FindByName("Correctas").Points.Add(int.Parse(lblPorcentajeRendimiento.Text));

            if (yield > 50)
            {
                lblPorcentajeRendimiento.ForeColor = Color.Red;
            }
            else
            {
                lblPorcentajeRendimiento.ForeColor = Color.ForestGreen;
            }
            
        }

        public void ObtainDayResults(string day, string month, string year, string model, string week)
        {
            pzas_correctas = 0;
            pzas_incorrectas = 0;

            try
            {
                string dirDia = @"c:\Reportes\" + month + "_" + year + @"\" + day + "_" + month + "_" + year + "_" + week + ".csv";
                string[] list = File.ReadAllLines(dirDia);

                for(int i = 1; i<list.Length; i++)
                {
                    string[] vals = list[i].Split(',');

                    if (vals[0] == model) //Si es el modelo seleccionado
                    {
                        if (vals[4] == "BUENA") //Nota, el archivo tal vez todavia no quede así al final.
                        {
                            pzas_correctas++;
                        }
                        else
                        {
                            pzas_incorrectas++;
                        }
                    }                   

                }

            }
            catch
            {

            }


        }

        public string RendimientoYield()
        {
            string rendimiento="";
            float porcentajeincorrectas = (100 * pzas_incorrectas) / pzas_totales;
            float eficiencia = 100 - porcentajeincorrectas;
            rendimiento = eficiencia.ToString("F2") + "%";
            yield = eficiencia;
            return rendimiento;
        }

        int numeroSemana(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        #endregion

        #region Devices
        public void verifydevices() //Aqui se pondrá una funcion para verificar conexion a dispositivos
        {
            int contDevices = 0;
            //Para verificar conexion a PLC
            try
            {
                PLC.Connect();
                contDevices = contDevices + 1;
            }
            catch { }

            if (!PLC.Connected)
            {
                MessageBox.Show("Error al conectar dispositivo PLC de entradas y salidas", "ERROR DE DISPOSITIVO");
            }

            //Verificar presencia de otros dispositivos            
            camaraAspirina.Conectar(IniSettings.IniReadValue("CamaraAspirina", "IP"));
            if (camaraAspirina.conectado)
            {
                LoginAspirina();
                contDevices = contDevices + 1;
            }
            else
            {
                MessageBox.Show("Error al conectar Camara de la Aspirina", "ERROR DE DISPOSITIVO");
            }               
           


            if (contDevices == 2) //Temporalmente solo verifica PLC y camara de la aspirina o sea dos dispositivos
            {
                devicesReady = true;
            }

        }
        public void closedevices()
        {
            //Terminar conexion con PLC
            try
            {
                PLC.Disconnect();
            }
            catch { }

            try
            {
                camaraAspirina.Desconectar();
            }
            catch
            {

            }

        }
        #endregion      

        #region Pruebas
        public void MainSecuence() //Aqui se pondrá la secuencia de prueba
        {
            while (programaIniciado)
            {
                //iniciar cronometro                
                reiniciarCronometro();

                //Acciones de prueba
                pieza_correcta = Test();
                //Envio de reportes
                resultReport(modelo, operador, estatusPieza, fails);
                //Impresion de etiqueta
                if (pieza_correcta)
                {
                   // imprimir_etiqueta();
                  //  FuncionPass();
                }
                else
                {
                   // FuncionFail();
                }

                //Finalizar cronometro
                StopCrono();
            }

        }
        public bool Test() //Devuelve boleano si pasó o falló la prueba y se hacen las pruebas 
        {
            bool test = false;
            //Pruebas


            return test;
        }
        public void Manivela()
        {
            string anguloStr;
            string basura; //Para sacar las lecturas basura que tenga la camara

            basura = camaraAspirina.Leer(); //Leemos para quitar respuestas anteriores
            TriggerAspirina();
            anguloStr = camaraAspirina.EnviarComando("GVOutput" + (char)13 + (char)10);  //Comando para obtener resultado de la herramienta Math_1 celda A0
            anguloStr = anguloStr.Substring(2);           
            anguloAspirina = float.Parse(anguloStr);

        }
        public void RedCable()
        {

        }
        public void viewImage()
        {

        }
        public void electricTest()
        {

        }
        public void sonido()
        {

        }
        public void verifyLabels()
        {

        }
        public void switch1()
        {

        }
        public void switch2()
        {

        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void timer_cronometro_Tick(object sender, EventArgs e)
        {            
            string m = Convert.ToString(mm);
            string s = Convert.ToString(ss);

            if (mm < 10)
            {
                m = Convert.ToString("0" + mm);
            }
            if (ss < 10)
            {
                s = Convert.ToString("0" + ss);
            }

            lblTime.Text = Convert.ToString(m + ":" + s);
            ss += 1;
            if (ss >= 59)
            {
                mm += 1;
                ss = 0;
            }
        }
        private void reiniciarCronometro()
        {
            lblTime.Text = "00:00";
            mm = 0;
            ss = 0;
            timer_cronometro.Stop();
        }

        private void StartCron()
        {
            timer_cronometro.Start();
        }

        private void StopCrono()
        {
            timer_cronometro.Stop();
        }

        public void Andon(string color) //Manejo de la torreta de colores
        {
            switch (color)
            {
                case "verde":
                    {
                        PLC.WriteSingleCoil(O_lampVerde, true); //De prueba, hay que saber el verdadero 
                        PLC.WriteSingleCoil(O_lampAmar, false);
                        PLC.WriteSingleCoil(O_lampAzul, false);
                        PLC.WriteSingleCoil(O_lampRoja, false);
                        break;
                    }
                case "roja":
                    {
                        PLC.WriteSingleCoil(O_lampRoja, true); //De prueba, hay que saber el verdadero 
                        PLC.WriteSingleCoil(O_lampAmar, false);
                        PLC.WriteSingleCoil(O_lampAzul, false);
                        PLC.WriteSingleCoil(O_lampVerde, false);
                        break;
                    }
                case "amarilla":
                    {
                        PLC.WriteSingleCoil(O_lampAmar, true); //De prueba, hay que saber el verdadero 
                        PLC.WriteSingleCoil(O_lampVerde, false);
                        PLC.WriteSingleCoil(O_lampAzul, false);
                        PLC.WriteSingleCoil(O_lampRoja, false);
                        break;
                    }
                case "azul":
                    {
                        PLC.WriteSingleCoil(O_lampAzul, true); //De prueba, hay que saber el verdadero 
                        PLC.WriteSingleCoil(O_lampAmar, false);
                        PLC.WriteSingleCoil(O_lampVerde, false);
                        PLC.WriteSingleCoil(O_lampRoja, false);
                        break;
                    }
            }
        }

        public bool InitSecuence() //Esta función va a verificar que el operador haya presionado ambos sensores (como optos)
        {
            bool resp = false;


            return resp;
        }

        public void LiberarPieza()
        {
            //Aqui es para que la maquina suelte la pieza para que el usuario pueda retirarla y continue con las pruebas.
        }

        #endregion

        #region Aspirina
        public void LoginAspirina()
        {
            /*Login*/
            //Leer mensaje de bienvenida
            string respuestaTemp = camaraAspirina.Leer();
            //Introducir usuario
            respuestaTemp = camaraAspirina.EnviarComando("admin" + (char)13 + (char)10 + " \n");
            //Introducir contraseña
            respuestaTemp = camaraAspirina.EnviarComando("" + (char)13 + (char)10 + " \n");

            //Verificar que no se quedo ningun dato sin leer
            respuestaTemp = camaraAspirina.Leer();
        }

        public void TriggerAspirina()
        {
            camaraAspirina.EnviarComandoSinRespuesta("SE8" + (char)13 + (char)10); //Cambio del comando original(MT) a SE8 para camara nueva D905
        }


        #endregion

        #endregion //Region general

    }
}
