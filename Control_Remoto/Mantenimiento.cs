using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MccDaq;
using System.IO;
using ModbusTCP;
using System.Net;
using System.Net.Sockets;
using GRABCYC;
using DigitalIO;
using ErrorDefs;

namespace Control_Remoto
{
    public partial class Mantenimiento : Form
    {
        #region variables
        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");
        public static string dbDir = Directory.GetCurrentDirectory() + "\\Settings\\Modelos.csv";             
        int m, mx, my;
        Sistema_Vision main = new Sistema_Vision();
        #endregion
        public Mantenimiento()
        {
            InitializeComponent();
        }

        //NOTA: PANEL2 ES EL PANEL DE LA BARRA DE ARRIBA
        #region funcionesVentana
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {     
           LoadTable();

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
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

        private void Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verificar si otras ventanas de mantenimiento estan abiertas
            if (Application.OpenForms["Parametros"] == null && Application.OpenForms["IOViewer"] == null && Application.OpenForms["frmManual"]==null) 
            {
                main.Visible = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {  
            //No hago nada, ya estoy en la opcion modelos
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
            //Abrir ventana nueva de Mantenimiento Configuracion
            Parametros config = new Parametros();
            config.Show();
            this.Close();
        }

        private void btnManejo_Click(object sender, EventArgs e)
        {
            //Abrir ventana nueva de Mantenimiento Manejo manual
            frmManual manual = new frmManual();
            manual.Show();
            this.Close();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
        #region Modelos
        private void btnAgregar_Click(object sender, EventArgs e) //Agregar modelo
        {
            if (tbModelo.Text != "")
            {
                if (tbRevision.Text != "")
                {
                    if (MessageBox.Show("Desea agregar nuevo modelo?", "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        //Estos ifs son para verificar los estados de los checkboxs para las pruebas
                        string[] checks = new string[15];
                        if (chB1.Checked) checks[0] = "X"; else checks[0] = "";
                        if (chB2.Checked) checks[1] = "X"; else checks[1] = "";
                        if (chB3.Checked) checks[2] = "X"; else checks[2] = "";
                        if (chB4.Checked) checks[3] = "X"; else checks[3] = "";
                        if (chB5.Checked) checks[4] = "X"; else checks[4] = "";
                        if (chB6.Checked) checks[5] = "X"; else checks[5] = "";
                        if (chB7.Checked) checks[6] = "X"; else checks[6] = "";
                        if (chB8.Checked) checks[7] = "X"; else checks[7] = "";
                        if (chB9.Checked) checks[8] = "X"; else checks[8] = "";
                        if (chB10.Checked) checks[9] = "X"; else checks[9] = "";
                        if (chB11.Checked) checks[10] = "X"; else checks[10] = "";
                        if (chB12.Checked) checks[11] = "X"; else checks[11] = "";
                        if (chB13.Checked) checks[12] = "X"; else checks[12] = "";
                        if (chB14.Checked) checks[13] = "X"; else checks[13] = "";
                        if (chB15.Checked) checks[14] = "X"; else checks[14] = "";

                        dgvModelos.Rows.Add(tbModelo.Text, tbRevision.Text, cbColor.Text, checks[0], checks[1], checks[2], checks[3], checks[4], checks[5], checks[6], checks[7], checks[8], checks[9], checks[10], checks[11], checks[12], checks[13], checks[14]);
                        SaveFunction();
                        LoadTable();
                        cleanPanelModel();
                    }
                    else
                    {
                        cleanPanelModel();
                    }
                        
                }
                else
                {
                    MessageBox.Show("FAVOR DE INGRESAR REVISION");
                }
            }
            else
            {
                MessageBox.Show("FAVOR DE INGRESAR MODELO");
            }
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbModelo.Text != "")
            {
                if (tbRevision.Text != "")
                {
                    if (MessageBox.Show("Desea modificar este modelo?", "AVISO", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {                        
                        dgvModelos.Rows.RemoveAt(dgvModelos.CurrentRow.Index);
                        string[] checks = new string[15];
                        if (chB1.Checked) checks[0] = "X"; else checks[0] = "";
                        if (chB2.Checked) checks[1] = "X"; else checks[1] = "";
                        if (chB3.Checked) checks[2] = "X"; else checks[2] = "";
                        if (chB4.Checked) checks[3] = "X"; else checks[3] = "";
                        if (chB5.Checked) checks[4] = "X"; else checks[4] = "";
                        if (chB6.Checked) checks[5] = "X"; else checks[5] = "";
                        if (chB7.Checked) checks[6] = "X"; else checks[6] = "";
                        if (chB8.Checked) checks[7] = "X"; else checks[7] = "";
                        if (chB9.Checked) checks[8] = "X"; else checks[8] = "";
                        if (chB10.Checked) checks[9] = "X"; else checks[9] = "";
                        if (chB11.Checked) checks[10] = "X"; else checks[10] = "";
                        if (chB12.Checked) checks[11] = "X"; else checks[11] = "";
                        if (chB13.Checked) checks[12] = "X"; else checks[12] = "";
                        if (chB14.Checked) checks[13] = "X"; else checks[13] = "";
                        if (chB15.Checked) checks[14] = "X"; else checks[14] = "";

                        dgvModelos.Rows.Add(tbModelo.Text, tbRevision.Text, cbColor.Text, checks[0], checks[1], checks[2], checks[3], checks[4], checks[5], checks[6], checks[7], checks[8], checks[9], checks[10], checks[11], checks[12], checks[13], checks[14]);
                       
                        SaveFunction();
                        LoadTable();
                        cleanPanelModel();
                    }
                    else
                    {
                        cleanPanelModel();
                    }
                }
                else
                {
                    MessageBox.Show("FAVOR DE INGRESAR REVISION");
                }
            }
            else
            {
                MessageBox.Show("FAVOR DE INGRESAR MODELO");
            }

            SaveFunction();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar para siempre este modelo?", "AVISO", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                dgvModelos.Rows.RemoveAt(dgvModelos.CurrentRow.Index);
                SaveFunction();
                LoadTable();

            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbModelo.Text = dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[0].Value.ToString();
            tbRevision.Text = dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[1].Value.ToString();
            cbColor.Text = dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[2].Value.ToString();
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[3].Value.ToString(), chB1);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[4].Value.ToString(), chB2);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[5].Value.ToString(), chB3);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[6].Value.ToString(), chB4);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[7].Value.ToString(), chB5);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[8].Value.ToString(), chB6);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[9].Value.ToString(), chB7);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[10].Value.ToString(), chB8);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[11].Value.ToString(), chB9);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[12].Value.ToString(), chB10);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[13].Value.ToString(), chB11);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[14].Value.ToString(), chB12);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[15].Value.ToString(), chB13);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[16].Value.ToString(), chB14);
            CheckPruebas(dgvModelos.Rows[dgvModelos.CurrentRow.Index].Cells[17].Value.ToString(), chB15);
        }

        private void CheckPruebas(string check, CheckBox chb)
        {           
           if(check == "X")
           {
               chb.Checked = true;
           }
           else
           {
                chb.Checked = false;
           }
        }

        private void cleanPanelModel()
        {
            tbModelo.Text = "";
            tbRevision.Text = "";
            cbColor.Text = "";
            chB1.Checked = false;
            chB2.Checked = false;
            chB3.Checked = false;
            chB4.Checked = false;
            chB5.Checked = false;
            chB6.Checked = false;
            chB7.Checked = false;
            chB8.Checked = false;
            chB9.Checked = false;
            chB10.Checked = false;
            chB11.Checked = false;
            chB12.Checked = false;
            chB13.Checked = false;
            chB14.Checked = false;
            chB15.Checked = false;
        }

        private void SaveFunction() //Funcion para guardar datos nuevos al archivo de modelos
        {
            string[] list = new string[dgvModelos.Rows.Count]; //Crea una lista con la cantidad de filas contadas en el archivo csv.
            list[0] = "Modelo,Revision,Color,Prueba1,Prueba2,Prueba3,Prueba4,Prueba5,Prueba6,Prueba7,Prueba8,Prueba9,Prueba10,Prueba11,Prueba12,Prueba13,Prueba14,Prueba15";
            for (int i = 0; i < list.Length-1; i++)
            {
                string v1 = dgvModelos.Rows[i].Cells[0].Value.ToString();
                string v2 = dgvModelos.Rows[i].Cells[1].Value.ToString();
                string v3 = dgvModelos.Rows[i].Cells[2].Value.ToString();
                string v4 = dgvModelos.Rows[i].Cells[3].Value.ToString();
                string v5 = dgvModelos.Rows[i].Cells[4].Value.ToString();
                string v6 = dgvModelos.Rows[i].Cells[5].Value.ToString();
                string v7 = dgvModelos.Rows[i].Cells[6].Value.ToString();
                string v8 = dgvModelos.Rows[i].Cells[7].Value.ToString();
                string v9 = dgvModelos.Rows[i].Cells[8].Value.ToString();
                string v10 = dgvModelos.Rows[i].Cells[9].Value.ToString();
                string v11 = dgvModelos.Rows[i].Cells[10].Value.ToString();
                string v12 = dgvModelos.Rows[i].Cells[11].Value.ToString();
                string v13 = dgvModelos.Rows[i].Cells[12].Value.ToString();
                string v14 = dgvModelos.Rows[i].Cells[13].Value.ToString();
                string v15 = dgvModelos.Rows[i].Cells[14].Value.ToString();
                string v16 = dgvModelos.Rows[i].Cells[15].Value.ToString();
                string v17 = dgvModelos.Rows[i].Cells[16].Value.ToString();
                string v18 = dgvModelos.Rows[i].Cells[17].Value.ToString();


                list[i + 1] = v1 + "," + v2 + "," + v3 + "," + v4 + "," + v5 + "," + v6 + "," + v7 + "," + v8 + "," + v9 + "," + v10 + "," + v11 + "," + v12 + "," + v13 + "," + v14 + "," + v15 + "," + v16 + "," + v17 + "," + v18;

            }
            File.WriteAllLines(dbDir, list);
            LoadTable();

        }

        private void LoadTable() //Funcion que recarga la tabla cuando hay cambios en los modelos
        {
            dgvModelos.Rows.Clear();
            string[] list = File.ReadAllLines(dbDir);
            for(int i =1; i<list.Length; i++)
            {
                string[] vals = list[i].Split(',');
                dgvModelos.Rows.Add(vals[0], vals[1], vals[2], vals[3], vals[4], vals[5], vals[6], vals[7], vals[8], vals[9], vals[10], vals[11], vals[12], vals[13], vals[14],vals[15],vals[16],vals[17]);
            }

        }
        #endregion


    }
}
