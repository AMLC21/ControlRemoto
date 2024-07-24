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

namespace Control_Remoto
{
    public partial class Password_Calidad : Form
    {
        int m, mx, my;
        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");
        public static string dbDir = Directory.GetCurrentDirectory() + "\\Settings\\Users.csv";

        public Password_Calidad()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            txt_usuario.Select();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string[] list = File.ReadAllLines(dbDir);
            string message="";

            try
            {
                for(int i = 0; i< list.Length; i++)
                {
                    string[] vals = list[i].Split(',');
                                                    
                   if (vals[0] == txt_usuario.Text) //Verifica que exista usuario
                   {
                      if (vals[1] == txt_pass.Text) //Verifica que contraseña sea correcta
                      {
                            if (vals[2] == "Programacion" || vals[2] == "Calidad") //Verifica que pertenezca al departamento correcto
                            {
                                message = "";
                                DialogResult = DialogResult.OK;
                                this.Close();
                                break;                                
                            }
                            else
                            {
                                message = "Tu usuario y contraseña son correctas, pero no tienes acceso a estos módulos";
                                break;
                            }
                               
                      }
                      else
                      {
                          message = "Contraseña incorrecta";
                          break;
                      }

                   }
                   else
                   {
                      message = "Usuario no encontrado";
                   }              
                   
                    
                }

                //Si nunca cerró la ventana significa que nunca encontró conicidencias
                if(message != "")
                {
                    MessageBox.Show(message);
                }
               

            }
            catch(Exception Ex)
            {
                          
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_entrar.PerformClick();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
