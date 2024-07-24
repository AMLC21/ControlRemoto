namespace Control_Remoto
{
    partial class Impresion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresion));
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_personalizado = new System.Windows.Forms.TextBox();
            this.txt_assembled = new System.Windows.Forms.TextBox();
            this.txt_inspection = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_mercury = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(251, 338);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(140, 34);
            this.btn_imprimir.TabIndex = 4;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dtp_hora);
            this.panel1.Controls.Add(this.dtp_fecha);
            this.panel1.Controls.Add(this.txt_personalizado);
            this.panel1.Controls.Add(this.txt_assembled);
            this.panel1.Controls.Add(this.txt_inspection);
            this.panel1.Controls.Add(this.txt_modelo);
            this.panel1.Controls.Add(this.txt_mercury);
            this.panel1.Location = new System.Drawing.Point(33, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 259);
            this.panel1.TabIndex = 5;
            // 
            // dtp_hora
            // 
            this.dtp_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora.Location = new System.Drawing.Point(422, 183);
            this.dtp_hora.Name = "dtp_hora";
            this.dtp_hora.Size = new System.Drawing.Size(104, 22);
            this.dtp_hora.TabIndex = 6;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(52, 185);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(104, 22);
            this.dtp_fecha.TabIndex = 5;
            // 
            // txt_personalizado
            // 
            this.txt_personalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personalizado.Location = new System.Drawing.Point(124, 215);
            this.txt_personalizado.Name = "txt_personalizado";
            this.txt_personalizado.Size = new System.Drawing.Size(337, 22);
            this.txt_personalizado.TabIndex = 7;
            this.txt_personalizado.Text = "Mercury Marine";
            this.txt_personalizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_assembled
            // 
            this.txt_assembled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_assembled.Location = new System.Drawing.Point(124, 148);
            this.txt_assembled.Name = "txt_assembled";
            this.txt_assembled.Size = new System.Drawing.Size(337, 22);
            this.txt_assembled.TabIndex = 4;
            this.txt_assembled.Text = "Mercury Marine";
            this.txt_assembled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_inspection
            // 
            this.txt_inspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inspection.Location = new System.Drawing.Point(124, 109);
            this.txt_inspection.Name = "txt_inspection";
            this.txt_inspection.Size = new System.Drawing.Size(337, 22);
            this.txt_inspection.TabIndex = 3;
            this.txt_inspection.Text = "Mercury Marine";
            this.txt_inspection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelo.Location = new System.Drawing.Point(124, 72);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(337, 22);
            this.txt_modelo.TabIndex = 2;
            this.txt_modelo.Text = "Mercury Marine";
            this.txt_modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mercury
            // 
            this.txt_mercury.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mercury.Location = new System.Drawing.Point(52, 26);
            this.txt_mercury.Name = "txt_mercury";
            this.txt_mercury.Size = new System.Drawing.Size(474, 29);
            this.txt_mercury.TabIndex = 1;
            this.txt_mercury.Text = "Mercury Marine";
            this.txt_mercury.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(601, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(45, 39);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(206)))), ((int)(((byte)(207)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.BtnCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(646, 39);
            this.panel4.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(479, 22);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "CONTROL REMOTO: IMPRESION PERSONALIZADA";
            // 
            // Impresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(646, 418);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(646, 418);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(646, 418);
            this.Name = "Impresion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresion";
            this.Load += new System.EventHandler(this.Impresion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_mercury;
        private System.Windows.Forms.TextBox txt_assembled;
        private System.Windows.Forms.TextBox txt_inspection;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.DateTimePicker dtp_hora;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox txt_personalizado;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitulo;
    }
}