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


namespace Control_Remoto
{
    public partial class Parametros : Form
    {

        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");
        Sistema_Vision main = new Sistema_Vision();
        int m, mx, my;
        public Parametros()
        {
            InitializeComponent();
        }

        private void Parametros_Load(object sender, EventArgs e) 
        {
            //Verificacion de escaner operador
            main.activeScanOp = IniSettings.IniReadValue("EscanerOp", "activo");
            if (main.activeScanOp=="Si")
            {
                chkEscanerOp.Checked = true;
            }
            else
            {
                chkEscanerOp.Checked = false;
            }
            //Usuario y contraseña
            //tbUser.Text = IniSettings.IniReadValue("Parametros", "usuario");
            //tbPassword.Text = IniSettings.IniReadValue("Parametros", "contrasena");

            //PLC
            tbIPPLC.Text = IniSettings.IniReadValue("PLC", "IP");
            //Puertos de los motores
            cbMotor1.Text = IniSettings.IniReadValue("Motor1", "Port");
            cbMotor2.Text = IniSettings.IniReadValue("Motor2", "Port");
            cbMotor2.Text = IniSettings.IniReadValue("Motor3", "Port");

            //Cargar puertos seriales disponibles en cada combobox
            string[] Port = SerialPort.GetPortNames();
            foreach(string i in Port)
            {
                cbMotor1.Items.Add(i);
                cbMotor2.Items.Add(i);
                cbMotor3.Items.Add(i);
            }

        }
        private void Parametros_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verificar si otras ventanas de mantenimiento estan abiertas
            if (Application.OpenForms["Mantenimiento"] == null && Application.OpenForms["IOViewer"] == null && Application.OpenForms["frmManual"] == null)
            {
                main.Visible = true;
                //Instrucciones de actualizacion de la ventana Main para la verificacion del numero de operador
                main.operador = IniSettings.IniReadValue("EscanerOp", "lastoper");
                main.lblOperador.Text = "Operador: " + main.operador;
                main.activeScanOp = IniSettings.IniReadValue("EscanerOp", "activo");
            }
        }

        #region FuncionesVentana
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Parametros_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            Mantenimiento models = new Mantenimiento();
            models.Show();
            this.Close();
        }

        private void btnIOVIEWER_Click(object sender, EventArgs e)
        {
            IOViewer iov = new IOViewer();
            iov.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            //No hago nada, ya estoy en configuracion
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            CambiosOperador();           
            CambiosPLC();
            MessageBox.Show("NOTA: Los cambios efectuados requieren reiniciar la aplicación para su correcto funcionamiento");
            this.Close();
        }

        private void Parametros_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Parametros_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }



        #endregion

        #region FuncionesExtra

        public void CambiosOperador()
        {
            //Escaner operador
            if (chkEscanerOp.Checked == true)
            {
                IniSettings.IniWriteValue("EscanerOp", "activo", "Si");
            }
            else
            {
                IniSettings.IniWriteValue("EscanerOp", "activo", "No");
                IniSettings.IniWriteValue("EscanerOp", "lastoper", "No_Operador");
            }
        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            frmAdminUsers adusers = new frmAdminUsers();
            adusers.Show();
        }

        private void btnImpEtiqueta_Click(object sender, EventArgs e)
        {
            Impresion impr = new Impresion();
            impr.Show();
        }

        private void btnManejo_Click(object sender, EventArgs e)
        {
            //Abrir ventana nueva de Mantenimiento Manejo manual
            frmManual manual = new frmManual();
            manual.Show();
            this.Close();
        }
               

        public void CambiosPLC()
        {
            IniSettings.IniWriteValue("PLC", "IP", tbIPPLC.Text);
        }
              

        #endregion


    }
}
