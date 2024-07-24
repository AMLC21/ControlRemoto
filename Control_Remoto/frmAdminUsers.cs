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
    public partial class frmAdminUsers : Form
    {
        #region variables        

        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");    
        public static string dbDir = Directory.GetCurrentDirectory() + "\\Settings\\Users.csv";

        #endregion      

        public frmAdminUsers()
        {
            InitializeComponent();
        }

        private void frmAdminUsers_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Borrar usuario existente
            if (MessageBox.Show("Desea eliminar para siempre este modelo?", "AVISO", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                dgvUsers.Rows.RemoveAt(dgvUsers.CurrentRow.Index);
                SaveTable();
                LoadTable();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar nuevo usuario
            if (tbUser.Text != "")
            {
                if(tbDepto.Text != "")
                {
                    if(tbPass.Text != "")
                    {
                        if (MessageBox.Show("¿Desea agregar nuevo usuario?", "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            dgvUsers.Rows.Add(tbUser.Text, tbPass.Text, tbDepto.Text);
                            SaveTable();
                            LoadTable();
                            CleanPanel();
                        }
                        else
                        {
                            CleanPanel();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Favor de ingresar una contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Favor de ingresar departamento del usuario: \n (Mantenimiento o Calidad)");
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar un nombre de usuario");
            }
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Modificar usuario existente 
            if (tbUser.Text != "")
            {
                if (tbDepto.Text != "")
                {
                    if (tbPass.Text != "")
                    {
                        if (MessageBox.Show("¿Desea modificar este usuario?", "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            dgvUsers.Rows.RemoveAt(dgvUsers.CurrentRow.Index);
                            dgvUsers.Rows.Add(tbUser.Text, tbPass.Text, tbDepto.Text);
                            SaveTable();
                            LoadTable();
                            CleanPanel();
                        }
                        else
                        {
                            CleanPanel();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Favor de ingresar una contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Favor de ingresar departamento del usuario: \n (Mantenimiento o Calidad)");
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar un nombre de usuario");
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbUser.Text = dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value.ToString();
            tbPass.Text = dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[1].Value.ToString();
            tbDepto.Text = dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[2].Value.ToString();
        }


        #region funciones
        private void LoadTable()
        {
            dgvUsers.Rows.Clear();
            string[] list = File.ReadAllLines(dbDir);
            for (int i = 1; i < list.Length; i++)
            {
                string[] vals = list[i].Split(',');
                dgvUsers.Rows.Add(vals[0], vals[1], vals[2]);
            }
        }
        
        private void SaveTable()
        {
            string[] list = new string[dgvUsers.Rows.Count];
            list[0] = "User,Password,Depto";

            for(int i = 0; i < list.Length-1; i++)
            {
                string v1 = dgvUsers.Rows[i].Cells[0].Value.ToString();
                string v2 = dgvUsers.Rows[i].Cells[1].Value.ToString();
                string v3 = dgvUsers.Rows[i].Cells[2].Value.ToString();

                list[i + 1] = v1 + "," + v2 + "," + v3;
            }

            File.WriteAllLines(dbDir, list);
            LoadTable();

        }

        private void CleanPanel()
        {
            tbUser.Clear();
            tbPass.Clear();
            tbDepto.Text = "";
        }

        #endregion
    }
}
