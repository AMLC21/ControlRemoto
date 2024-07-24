namespace Control_Remoto
{
    partial class frmManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManual));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnManejo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIOVIEWER = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDir1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMove1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVel1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMicro1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDir2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMove2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVel2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMicro2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDir3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMove3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVel3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMicro3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbAngulo = new System.Windows.Forms.TextBox();
            this.btnReadAngle = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.panel4.TabIndex = 18;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(376, 22);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "CONTROL REMOTO: MANEJO MANUAL";
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
            this.pnlMenu.TabIndex = 22;
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
            this.btnManejo.ForeColor = System.Drawing.Color.Gold;
            this.btnManejo.Location = new System.Drawing.Point(3, 419);
            this.btnManejo.Name = "btnManejo";
            this.btnManejo.Size = new System.Drawing.Size(171, 50);
            this.btnManejo.TabIndex = 18;
            this.btnManejo.Text = "MANEJO MANUAL";
            this.btnManejo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManejo.UseVisualStyleBackColor = true;
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
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(3, 345);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(171, 50);
            this.btnConfig.TabIndex = 17;
            this.btnConfig.Text = "CONFIGURACION";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDir1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnMove1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbVel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMicro1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(198, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 105);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor 1";
            // 
            // cbDir1
            // 
            this.cbDir1.FormattingEnabled = true;
            this.cbDir1.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbDir1.Location = new System.Drawing.Point(209, 47);
            this.cbDir1.Name = "cbDir1";
            this.cbDir1.Size = new System.Drawing.Size(76, 24);
            this.cbDir1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dirección";
            // 
            // btnMove1
            // 
            this.btnMove1.Location = new System.Drawing.Point(310, 32);
            this.btnMove1.Name = "btnMove1";
            this.btnMove1.Size = new System.Drawing.Size(83, 59);
            this.btnMove1.TabIndex = 4;
            this.btnMove1.Text = "Mover";
            this.btnMove1.UseVisualStyleBackColor = true;
            this.btnMove1.Click += new System.EventHandler(this.btnMove1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocidad";
            // 
            // tbVel1
            // 
            this.tbVel1.Location = new System.Drawing.Point(127, 48);
            this.tbVel1.Name = "tbVel1";
            this.tbVel1.Size = new System.Drawing.Size(76, 23);
            this.tbVel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Microsteps";
            // 
            // tbMicro1
            // 
            this.tbMicro1.Location = new System.Drawing.Point(16, 48);
            this.tbMicro1.Name = "tbMicro1";
            this.tbMicro1.Size = new System.Drawing.Size(105, 23);
            this.tbMicro1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDir2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnMove2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbVel2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbMicro2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 105);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motor 2";
            // 
            // cbDir2
            // 
            this.cbDir2.FormattingEnabled = true;
            this.cbDir2.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbDir2.Location = new System.Drawing.Point(209, 47);
            this.cbDir2.Name = "cbDir2";
            this.cbDir2.Size = new System.Drawing.Size(76, 24);
            this.cbDir2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dirección";
            // 
            // btnMove2
            // 
            this.btnMove2.Location = new System.Drawing.Point(310, 30);
            this.btnMove2.Name = "btnMove2";
            this.btnMove2.Size = new System.Drawing.Size(83, 59);
            this.btnMove2.TabIndex = 4;
            this.btnMove2.Text = "Mover";
            this.btnMove2.UseVisualStyleBackColor = true;
            this.btnMove2.Click += new System.EventHandler(this.btnMove2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Velocidad";
            // 
            // tbVel2
            // 
            this.tbVel2.Location = new System.Drawing.Point(127, 48);
            this.tbVel2.Name = "tbVel2";
            this.tbVel2.Size = new System.Drawing.Size(76, 23);
            this.tbVel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Microsteps";
            // 
            // tbMicro2
            // 
            this.tbMicro2.Location = new System.Drawing.Point(16, 48);
            this.tbMicro2.Name = "tbMicro2";
            this.tbMicro2.Size = new System.Drawing.Size(105, 23);
            this.tbMicro2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDir3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnMove3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbVel3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbMicro3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(198, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 105);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor 3";
            // 
            // cbDir3
            // 
            this.cbDir3.FormattingEnabled = true;
            this.cbDir3.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbDir3.Location = new System.Drawing.Point(209, 46);
            this.cbDir3.Name = "cbDir3";
            this.cbDir3.Size = new System.Drawing.Size(76, 24);
            this.cbDir3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Dirección";
            // 
            // btnMove3
            // 
            this.btnMove3.Location = new System.Drawing.Point(310, 32);
            this.btnMove3.Name = "btnMove3";
            this.btnMove3.Size = new System.Drawing.Size(83, 59);
            this.btnMove3.TabIndex = 4;
            this.btnMove3.Text = "Mover";
            this.btnMove3.UseVisualStyleBackColor = true;
            this.btnMove3.Click += new System.EventHandler(this.btnMove3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Velocidad";
            // 
            // tbVel3
            // 
            this.tbVel3.Location = new System.Drawing.Point(127, 46);
            this.tbVel3.Name = "tbVel3";
            this.tbVel3.Size = new System.Drawing.Size(76, 23);
            this.tbVel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Microsteps";
            // 
            // tbMicro3
            // 
            this.tbMicro3.Location = new System.Drawing.Point(16, 46);
            this.tbMicro3.Name = "tbMicro3";
            this.tbMicro3.Size = new System.Drawing.Size(105, 23);
            this.tbMicro3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbAngulo);
            this.groupBox4.Controls.Add(this.btnReadAngle);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(198, 418);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 112);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camara de la Aspirina";
            // 
            // tbAngulo
            // 
            this.tbAngulo.Location = new System.Drawing.Point(16, 45);
            this.tbAngulo.Name = "tbAngulo";
            this.tbAngulo.Size = new System.Drawing.Size(269, 23);
            this.tbAngulo.TabIndex = 6;
            // 
            // btnReadAngle
            // 
            this.btnReadAngle.Location = new System.Drawing.Point(310, 31);
            this.btnReadAngle.Name = "btnReadAngle";
            this.btnReadAngle.Size = new System.Drawing.Size(83, 59);
            this.btnReadAngle.TabIndex = 5;
            this.btnReadAngle.Text = "Leer Angulo";
            this.btnReadAngle.UseVisualStyleBackColor = true;
            this.btnReadAngle.Click += new System.EventHandler(this.btnReadAngle_Click);
            // 
            // frmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManual";
            this.Text = "frmManual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManual_FormClosing);
            this.Load += new System.EventHandler(this.frmManual_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnManejo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIOVIEWER;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMicro1;
        private System.Windows.Forms.Button btnMove1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMove2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMicro2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMove3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMicro3;
        private System.Windows.Forms.ComboBox cbDir1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDir2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDir3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbAngulo;
        private System.Windows.Forms.Button btnReadAngle;
    }
}