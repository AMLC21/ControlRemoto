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
    public partial class frmCalidad : Form
    {
        public frmCalidad()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProduccion_Click(object sender, EventArgs e)
        {
            AbrirForm<GraficoProduccion>();
            BtnProduccion.BackColor = Color.Maroon;
        }

        #region Eventos Para Forms

        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form FormSelected;
            //Busca el formulario en la coleccion
            FormSelected = PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault();

            if (FormSelected == null)
            {
                FormSelected = new MiForm();
                FormSelected.TopLevel = false;
                FormSelected.FormBorderStyle = FormBorderStyle.None;
                FormSelected.Dock = DockStyle.Fill;
                PanelFormularios.Controls.Add(FormSelected);
                PanelFormularios.Tag = FormSelected;
                FormSelected.Show();
                FormSelected.BringToFront();
                FormSelected.FormClosed += new FormClosedEventHandler(CerrarForm);
            }
            else
            {
                FormSelected.BringToFront();
            }

        }


        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["GraficoProduccion"] == null) { BtnProduccion.BackColor = Color.FromArgb(68, 13, 15); }
            if (Application.OpenForms["AnalisisOperador"] == null) { BtnPersonal.BackColor = Color.FromArgb(68, 13, 15); }
        }

        #endregion

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            AbrirForm<AnalisisOperador>();
            BtnPersonal.BackColor = Color.Maroon;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
