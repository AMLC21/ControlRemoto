using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using IniFile;

namespace Control_Remoto
{
    public partial class frmOperador : Form
    {
        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");
        public frmOperador()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (tbOperador.Text != "")
            {
                IniSettings.IniWriteValue("EscanerOp", "lastoper", tbOperador.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Escanee o ingrese su numero de operador");
            }
            
        }

        private void frmOperador_Load(object sender, EventArgs e)
        {
            tbOperador.Focus();
        }

        private void tbOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnOk.PerformClick();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
