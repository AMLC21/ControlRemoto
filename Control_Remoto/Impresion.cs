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
    public partial class Impresion : Form
    {
        public Impresion()
        {
            InitializeComponent();
        }

        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");

        private void Impresion_Load(object sender, EventArgs e)
        {
            txt_mercury.Text = "Mercury Marine Plant 22";
            //txt_modelo.Text = "8M2101000";
            //txt_modelo.Text = Program.stingray;
            txt_inspection.Text = "Control Remoto";
            txt_assembled.Text = "Assembled in Mexico";
            dtp_fecha.Value = DateTime.Now;
            dtp_hora.Value = DateTime.Now;
            txt_personalizado.Text = "";
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                IniFile.Ini settings = IniSettings;
                string impresora = settings.IniReadValue("Impresora", "Nombre");
                StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Settings\\" + "\\label_personalizada.txt");
                string label = reader.ReadToEnd();
                label = label.Replace("MERCURY", txt_mercury.Text);
                label = label.Replace("MODELO", txt_modelo.Text);
                label = label.Replace("INSPECTION", txt_inspection.Text);
                label = label.Replace("ASSEMBLED", txt_assembled.Text);
                label = label.Replace("FECHA", dtp_fecha.Value.ToString("MM/dd/yyyy"));
                label = label.Replace("HORA", dtp_hora.Value.ToString("HH:mm:ss tt"));
                label = label.Replace("PERSO", txt_personalizado.Text);
                RawPrinterHelper.SendStringToPrinter(impresora, label);
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
