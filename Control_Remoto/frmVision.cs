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
using GRABCYC;

namespace Control_Remoto
{
    public partial class frmVision : Form
    {
        public frmVision()
        {
            InitializeComponent();
        }

        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");

        private void frmVision_Load(object sender, EventArgs e)
        {
           
        }        

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
