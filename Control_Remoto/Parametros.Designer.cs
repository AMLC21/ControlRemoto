namespace Control_Remoto
{
    partial class Parametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametros));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnModelos = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnManejo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIOVIEWER = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.chkEscanerOp = new System.Windows.Forms.CheckBox();
            this.gbDevices = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMotor3 = new System.Windows.Forms.ComboBox();
            this.cbMotor2 = new System.Windows.Forms.ComboBox();
            this.cbMotor1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIPPLC = new System.Windows.Forms.TextBox();
            this.gbOtherDev = new System.Windows.Forms.GroupBox();
            this.btnAdminUsers = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnImpEtiqueta = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbDevices.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOtherDev.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(206)))), ((int)(((byte)(207)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.btnMinimizar);
            this.panel4.Controls.Add(this.btnMaximizar);
            this.panel4.Controls.Add(this.BtnCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 39);
            this.panel4.TabIndex = 17;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Parametros_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Parametros_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Parametros_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 22);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "CONTROL REMOTO:CONFIGURACION";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimizar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(865, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 39);
            this.btnMinimizar.TabIndex = 22;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaximizar.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(910, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(45, 39);
            this.btnMaximizar.TabIndex = 21;
            this.btnMaximizar.Text = "❏";
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(955, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(45, 39);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "MANTENIMIENTO";
            // 
            // btnModelos
            // 
            this.btnModelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModelos.FlatAppearance.BorderSize = 0;
            this.btnModelos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnModelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelos.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelos.ForeColor = System.Drawing.Color.White;
            this.btnModelos.Location = new System.Drawing.Point(3, 197);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(171, 50);
            this.btnModelos.TabIndex = 15;
            this.btnModelos.Text = "MODELOS";
            this.btnModelos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModelos.UseVisualStyleBackColor = true;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.pnlMenu.Controls.Add(this.btnRegresar);
            this.pnlMenu.Controls.Add(this.btnManejo);
            this.pnlMenu.Controls.Add(this.label11);
            this.pnlMenu.Controls.Add(this.label12);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.btnIOVIEWER);
            this.pnlMenu.Controls.Add(this.btnConfig);
            this.pnlMenu.Controls.Add(this.btnModelos);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 39);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 561);
            this.pnlMenu.TabIndex = 21;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(3, 487);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(171, 50);
            this.btnRegresar.TabIndex = 19;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnManejo
            // 
            this.btnManejo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManejo.FlatAppearance.BorderSize = 0;
            this.btnManejo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnManejo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnManejo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManejo.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManejo.ForeColor = System.Drawing.Color.White;
            this.btnManejo.Location = new System.Drawing.Point(3, 419);
            this.btnManejo.Name = "btnManejo";
            this.btnManejo.Size = new System.Drawing.Size(171, 50);
            this.btnManejo.TabIndex = 18;
            this.btnManejo.Text = "MANEJO MANUAL";
            this.btnManejo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManejo.UseVisualStyleBackColor = true;
            this.btnManejo.Click += new System.EventHandler(this.btnManejo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnIOVIEWER
            // 
            this.btnIOVIEWER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIOVIEWER.FlatAppearance.BorderSize = 0;
            this.btnIOVIEWER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnIOVIEWER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnIOVIEWER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIOVIEWER.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIOVIEWER.ForeColor = System.Drawing.Color.White;
            this.btnIOVIEWER.Location = new System.Drawing.Point(0, 271);
            this.btnIOVIEWER.Name = "btnIOVIEWER";
            this.btnIOVIEWER.Size = new System.Drawing.Size(176, 50);
            this.btnIOVIEWER.TabIndex = 16;
            this.btnIOVIEWER.Text = "ENTRADAS/SALIDAS";
            this.btnIOVIEWER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIOVIEWER.UseVisualStyleBackColor = true;
            this.btnIOVIEWER.Click += new System.EventHandler(this.btnIOVIEWER_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Gold;
            this.btnConfig.Location = new System.Drawing.Point(3, 345);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(171, 50);
            this.btnConfig.TabIndex = 17;
            this.btnConfig.Text = "CONFIGURACION";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // chkEscanerOp
            // 
            this.chkEscanerOp.AutoSize = true;
            this.chkEscanerOp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEscanerOp.Location = new System.Drawing.Point(19, 30);
            this.chkEscanerOp.Name = "chkEscanerOp";
            this.chkEscanerOp.Size = new System.Drawing.Size(242, 23);
            this.chkEscanerOp.TabIndex = 23;
            this.chkEscanerOp.Text = "Activar escaneo de operador";
            this.chkEscanerOp.UseVisualStyleBackColor = true;
            // 
            // gbDevices
            // 
            this.gbDevices.Controls.Add(this.groupBox2);
            this.gbDevices.Controls.Add(this.groupBox1);
            this.gbDevices.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDevices.Location = new System.Drawing.Point(204, 61);
            this.gbDevices.Name = "gbDevices";
            this.gbDevices.Size = new System.Drawing.Size(362, 514);
            this.gbDevices.TabIndex = 24;
            this.gbDevices.TabStop = false;
            this.gbDevices.Text = "Configuracion de dispositivos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMotor3);
            this.groupBox2.Controls.Add(this.cbMotor2);
            this.groupBox2.Controls.Add(this.cbMotor1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motores";
            // 
            // cbMotor3
            // 
            this.cbMotor3.FormattingEnabled = true;
            this.cbMotor3.Location = new System.Drawing.Point(89, 106);
            this.cbMotor3.Name = "cbMotor3";
            this.cbMotor3.Size = new System.Drawing.Size(239, 25);
            this.cbMotor3.TabIndex = 10;
            // 
            // cbMotor2
            // 
            this.cbMotor2.FormattingEnabled = true;
            this.cbMotor2.Location = new System.Drawing.Point(89, 72);
            this.cbMotor2.Name = "cbMotor2";
            this.cbMotor2.Size = new System.Drawing.Size(239, 25);
            this.cbMotor2.TabIndex = 9;
            // 
            // cbMotor1
            // 
            this.cbMotor1.FormattingEnabled = true;
            this.cbMotor1.Location = new System.Drawing.Point(89, 38);
            this.cbMotor1.Name = "cbMotor1";
            this.cbMotor1.Size = new System.Drawing.Size(239, 25);
            this.cbMotor1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Motor3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Motor2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motor1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbIPPLC);
            this.groupBox1.Location = new System.Drawing.Point(7, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC-IO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP Address";
            // 
            // tbIPPLC
            // 
            this.tbIPPLC.Location = new System.Drawing.Point(89, 21);
            this.tbIPPLC.Name = "tbIPPLC";
            this.tbIPPLC.Size = new System.Drawing.Size(254, 25);
            this.tbIPPLC.TabIndex = 0;
            // 
            // gbOtherDev
            // 
            this.gbOtherDev.Controls.Add(this.btnImpEtiqueta);
            this.gbOtherDev.Controls.Add(this.btnAdminUsers);
            this.gbOtherDev.Controls.Add(this.chkEscanerOp);
            this.gbOtherDev.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOtherDev.Location = new System.Drawing.Point(583, 62);
            this.gbOtherDev.Name = "gbOtherDev";
            this.gbOtherDev.Size = new System.Drawing.Size(362, 242);
            this.gbOtherDev.TabIndex = 25;
            this.gbOtherDev.TabStop = false;
            this.gbOtherDev.Text = "Otras configuraciones";
            // 
            // btnAdminUsers
            // 
            this.btnAdminUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(206)))), ((int)(((byte)(207)))));
            this.btnAdminUsers.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsers.Location = new System.Drawing.Point(12, 97);
            this.btnAdminUsers.Name = "btnAdminUsers";
            this.btnAdminUsers.Size = new System.Drawing.Size(350, 55);
            this.btnAdminUsers.TabIndex = 27;
            this.btnAdminUsers.Text = "Administrar Usuarios";
            this.btnAdminUsers.UseVisualStyleBackColor = false;
            this.btnAdminUsers.Click += new System.EventHandler(this.btnAdminUsers_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.btnSaveConfig.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfig.Location = new System.Drawing.Point(589, 519);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(356, 55);
            this.btnSaveConfig.TabIndex = 26;
            this.btnSaveConfig.Text = "Guardar todos los cambios";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnImpEtiqueta
            // 
            this.btnImpEtiqueta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(206)))), ((int)(((byte)(207)))));
            this.btnImpEtiqueta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpEtiqueta.Location = new System.Drawing.Point(12, 187);
            this.btnImpEtiqueta.Name = "btnImpEtiqueta";
            this.btnImpEtiqueta.Size = new System.Drawing.Size(350, 55);
            this.btnImpEtiqueta.TabIndex = 28;
            this.btnImpEtiqueta.Text = "Impresion de etiqueta";
            this.btnImpEtiqueta.UseVisualStyleBackColor = false;
            this.btnImpEtiqueta.Click += new System.EventHandler(this.btnImpEtiqueta_Click);
            // 
            // Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.gbOtherDev);
            this.Controls.Add(this.gbDevices);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Parametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parametros_FormClosing);
            this.Load += new System.EventHandler(this.Parametros_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbDevices.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOtherDev.ResumeLayout(false);
            this.gbOtherDev.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnManejo;
        private System.Windows.Forms.Button btnIOVIEWER;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.CheckBox chkEscanerOp;
        private System.Windows.Forms.GroupBox gbDevices;
        private System.Windows.Forms.GroupBox gbOtherDev;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIPPLC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMotor3;
        private System.Windows.Forms.ComboBox cbMotor2;
        private System.Windows.Forms.ComboBox cbMotor1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdminUsers;
        private System.Windows.Forms.Button btnImpEtiqueta;
    }
}