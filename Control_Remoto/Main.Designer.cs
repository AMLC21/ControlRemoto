namespace Control_Remoto
{
    partial class Sistema_Vision
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Vision));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPruebaActual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblClampTrigger = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblPiezaP = new System.Windows.Forms.Label();
            this.lblParo = new System.Windows.Forms.Label();
            this.lblCortina = new System.Windows.Forms.Label();
            this.lblOpto = new System.Windows.Forms.Label();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.Tests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_fallas = new System.Windows.Forms.Label();
            this.lb_correcta = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btn_iniciar_detener = new System.Windows.Forms.Button();
            this.lb_modelo = new System.Windows.Forms.Label();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_conta_correctas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_conta_incorrectas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChangeOper = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCalidad = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPorcentajeRendimiento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBlackModel = new System.Windows.Forms.Button();
            this.btnGrayModel = new System.Windows.Forms.Button();
            this.chrtRendimiento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer_cronometro = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRendimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(206)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.lblPruebaActual);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvTests);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_fallas);
            this.panel1.Controls.Add(this.lb_correcta);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Location = new System.Drawing.Point(136, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 622);
            this.panel1.TabIndex = 0;
            // 
            // lblPruebaActual
            // 
            this.lblPruebaActual.AutoSize = true;
            this.lblPruebaActual.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPruebaActual.Location = new System.Drawing.Point(845, 9);
            this.lblPruebaActual.Name = "lblPruebaActual";
            this.lblPruebaActual.Size = new System.Drawing.Size(204, 33);
            this.lblPruebaActual.TabIndex = 21;
            this.lblPruebaActual.Text = "Prueba Actual";
            this.lblPruebaActual.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblClampTrigger);
            this.groupBox1.Controls.Add(this.lblHome);
            this.groupBox1.Controls.Add(this.lblPiezaP);
            this.groupBox1.Controls.Add(this.lblParo);
            this.groupBox1.Controls.Add(this.lblCortina);
            this.groupBox1.Controls.Add(this.lblOpto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(882, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 159);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTRADAS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(228, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "Clamp Trigger";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(228, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "Home";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(43, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "Pieza presente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(43, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Paro de Emergencia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(43, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Cortinas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(43, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Optoswitch";
            // 
            // lblClampTrigger
            // 
            this.lblClampTrigger.AutoSize = true;
            this.lblClampTrigger.BackColor = System.Drawing.Color.Gray;
            this.lblClampTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClampTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClampTrigger.Location = new System.Drawing.Point(194, 55);
            this.lblClampTrigger.Name = "lblClampTrigger";
            this.lblClampTrigger.Size = new System.Drawing.Size(25, 24);
            this.lblClampTrigger.TabIndex = 24;
            this.lblClampTrigger.Text = "   ";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Gray;
            this.lblHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(194, 25);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(25, 24);
            this.lblHome.TabIndex = 23;
            this.lblHome.Text = "   ";
            // 
            // lblPiezaP
            // 
            this.lblPiezaP.AutoSize = true;
            this.lblPiezaP.BackColor = System.Drawing.Color.Gray;
            this.lblPiezaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPiezaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiezaP.Location = new System.Drawing.Point(9, 115);
            this.lblPiezaP.Name = "lblPiezaP";
            this.lblPiezaP.Size = new System.Drawing.Size(25, 24);
            this.lblPiezaP.TabIndex = 22;
            this.lblPiezaP.Text = "   ";
            // 
            // lblParo
            // 
            this.lblParo.AutoSize = true;
            this.lblParo.BackColor = System.Drawing.Color.Gray;
            this.lblParo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblParo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParo.Location = new System.Drawing.Point(9, 85);
            this.lblParo.Name = "lblParo";
            this.lblParo.Size = new System.Drawing.Size(25, 24);
            this.lblParo.TabIndex = 21;
            this.lblParo.Text = "   ";
            // 
            // lblCortina
            // 
            this.lblCortina.AutoSize = true;
            this.lblCortina.BackColor = System.Drawing.Color.Gray;
            this.lblCortina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCortina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCortina.Location = new System.Drawing.Point(9, 55);
            this.lblCortina.Name = "lblCortina";
            this.lblCortina.Size = new System.Drawing.Size(25, 24);
            this.lblCortina.TabIndex = 20;
            this.lblCortina.Text = "   ";
            // 
            // lblOpto
            // 
            this.lblOpto.AutoSize = true;
            this.lblOpto.BackColor = System.Drawing.Color.Gray;
            this.lblOpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpto.Location = new System.Drawing.Point(9, 25);
            this.lblOpto.Name = "lblOpto";
            this.lblOpto.Size = new System.Drawing.Size(25, 24);
            this.lblOpto.TabIndex = 19;
            this.lblOpto.Text = "   ";
            // 
            // dgvTests
            // 
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tests,
            this.Instruction,
            this.Min,
            this.Value,
            this.Max,
            this.Result});
            this.dgvTests.Location = new System.Drawing.Point(661, 68);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.Size = new System.Drawing.Size(584, 357);
            this.dgvTests.TabIndex = 2;
            // 
            // Tests
            // 
            this.Tests.HeaderText = "Tests";
            this.Tests.Name = "Tests";
            this.Tests.Width = 70;
            // 
            // Instruction
            // 
            this.Instruction.HeaderText = "Instruction";
            this.Instruction.Name = "Instruction";
            this.Instruction.Width = 180;
            // 
            // Min
            // 
            this.Min.HeaderText = "Min";
            this.Min.Name = "Min";
            this.Min.Width = 50;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 60;
            // 
            // Max
            // 
            this.Max.HeaderText = "Max";
            this.Max.Name = "Max";
            this.Max.Width = 50;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.Width = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Control_Remoto.Properties.Resources.CRPaint;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_fallas
            // 
            this.lb_fallas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_fallas.AutoSize = true;
            this.lb_fallas.BackColor = System.Drawing.Color.Transparent;
            this.lb_fallas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_fallas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_fallas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fallas.Location = new System.Drawing.Point(984, 122);
            this.lb_fallas.Name = "lb_fallas";
            this.lb_fallas.Size = new System.Drawing.Size(2, 22);
            this.lb_fallas.TabIndex = 1;
            this.lb_fallas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_correcta
            // 
            this.lb_correcta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_correcta.AutoSize = true;
            this.lb_correcta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correcta.Location = new System.Drawing.Point(563, 558);
            this.lb_correcta.Name = "lb_correcta";
            this.lb_correcta.Size = new System.Drawing.Size(0, 24);
            this.lb_correcta.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(23, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(229, 33);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Resultado Pieza";
            this.lblMessage.Visible = false;
            // 
            // btn_iniciar_detener
            // 
            this.btn_iniciar_detener.BackgroundImage = global::Control_Remoto.Properties.Resources.button_iniciar;
            this.btn_iniciar_detener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iniciar_detener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar_detener.Enabled = false;
            this.btn_iniciar_detener.FlatAppearance.BorderSize = 0;
            this.btn_iniciar_detener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar_detener.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_detener.Location = new System.Drawing.Point(816, 58);
            this.btn_iniciar_detener.Name = "btn_iniciar_detener";
            this.btn_iniciar_detener.Size = new System.Drawing.Size(146, 46);
            this.btn_iniciar_detener.TabIndex = 4;
            this.btn_iniciar_detener.UseVisualStyleBackColor = true;
            this.btn_iniciar_detener.Click += new System.EventHandler(this.btn_iniciar_detener_Click);
            // 
            // lb_modelo
            // 
            this.lb_modelo.AutoSize = true;
            this.lb_modelo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modelo.Location = new System.Drawing.Point(994, 47);
            this.lb_modelo.Name = "lb_modelo";
            this.lb_modelo.Size = new System.Drawing.Size(164, 19);
            this.lb_modelo.TabIndex = 1;
            this.lb_modelo.Text = "Seleccione Modelo:";
            this.lb_modelo.Visible = false;
            // 
            // cb_modelo
            // 
            this.cb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(998, 76);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(271, 28);
            this.cb_modelo.TabIndex = 2;
            this.cb_modelo.Visible = false;
            this.cb_modelo.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 776);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Piezas Buenas:";
            // 
            // lb_conta_correctas
            // 
            this.lb_conta_correctas.AutoSize = true;
            this.lb_conta_correctas.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conta_correctas.Location = new System.Drawing.Point(394, 772);
            this.lb_conta_correctas.Name = "lb_conta_correctas";
            this.lb_conta_correctas.Size = new System.Drawing.Size(42, 46);
            this.lb_conta_correctas.TabIndex = 1;
            this.lb_conta_correctas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 776);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Piezas Malas:";
            // 
            // lb_conta_incorrectas
            // 
            this.lb_conta_incorrectas.AutoSize = true;
            this.lb_conta_incorrectas.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conta_incorrectas.Location = new System.Drawing.Point(820, 772);
            this.lb_conta_incorrectas.Name = "lb_conta_incorrectas";
            this.lb_conta_incorrectas.Size = new System.Drawing.Size(42, 46);
            this.lb_conta_incorrectas.TabIndex = 1;
            this.lb_conta_incorrectas.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(206)))), ((int)(((byte)(207)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnMaximizar);
            this.pnlTitulo.Controls.Add(this.BtnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1448, 39);
            this.pnlTitulo.TabIndex = 15;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
            this.pnlTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 24);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "CONTROL REMOTO";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimizar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(1313, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 39);
            this.btnMinimizar.TabIndex = 2;
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
            this.btnMaximizar.Location = new System.Drawing.Point(1358, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(45, 39);
            this.btnMaximizar.TabIndex = 1;
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
            this.BtnCerrar.Location = new System.Drawing.Point(1403, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(45, 39);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.panel3.Controls.Add(this.btnChangeOper);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnCalidad);
            this.panel3.Controls.Add(this.btnAbout);
            this.panel3.Controls.Add(this.btnMantenimiento);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 842);
            this.panel3.TabIndex = 19;
            // 
            // btnChangeOper
            // 
            this.btnChangeOper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeOper.FlatAppearance.BorderSize = 0;
            this.btnChangeOper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnChangeOper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnChangeOper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeOper.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeOper.ForeColor = System.Drawing.Color.White;
            this.btnChangeOper.Location = new System.Drawing.Point(0, 258);
            this.btnChangeOper.Name = "btnChangeOper";
            this.btnChangeOper.Size = new System.Drawing.Size(116, 50);
            this.btnChangeOper.TabIndex = 18;
            this.btnChangeOper.Text = "CAMBIO DE OPERADOR";
            this.btnChangeOper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeOper.UseVisualStyleBackColor = true;
            this.btnChangeOper.Click += new System.EventHandler(this.btnChangeOper_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "_________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "PRODUCCION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnCalidad
            // 
            this.btnCalidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalidad.FlatAppearance.BorderSize = 0;
            this.btnCalidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnCalidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalidad.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalidad.ForeColor = System.Drawing.Color.White;
            this.btnCalidad.Location = new System.Drawing.Point(0, 202);
            this.btnCalidad.Name = "btnCalidad";
            this.btnCalidad.Size = new System.Drawing.Size(119, 50);
            this.btnCalidad.TabIndex = 16;
            this.btnCalidad.Text = "CALIDAD";
            this.btnCalidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalidad.UseVisualStyleBackColor = true;
            this.btnCalidad.Click += new System.EventHandler(this.btnCalidad_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(1, 314);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(116, 50);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "INFORMACION";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.btnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Location = new System.Drawing.Point(2, 144);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(116, 50);
            this.btnMantenimiento.TabIndex = 15;
            this.btnMantenimiento.Text = "MANTENIMIENTO";
            this.btnMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(132, 42);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(92, 19);
            this.lblOperador.TabIndex = 20;
            this.lblOperador.Text = "Operador: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(132, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 19);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(233, 76);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 19);
            this.lblHora.TabIndex = 23;
            this.lblHora.Text = "Hora";
            // 
            // lblPorcentajeRendimiento
            // 
            this.lblPorcentajeRendimiento.AutoSize = true;
            this.lblPorcentajeRendimiento.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeRendimiento.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPorcentajeRendimiento.Location = new System.Drawing.Point(1004, 808);
            this.lblPorcentajeRendimiento.Name = "lblPorcentajeRendimiento";
            this.lblPorcentajeRendimiento.Size = new System.Drawing.Size(125, 46);
            this.lblPorcentajeRendimiento.TabIndex = 25;
            this.lblPorcentajeRendimiento.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(974, 776);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 27);
            this.label3.TabIndex = 26;
            this.label3.Text = "% Rendimiento:";
            // 
            // btnBlackModel
            // 
            this.btnBlackModel.BackColor = System.Drawing.Color.Black;
            this.btnBlackModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackModel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBlackModel.Location = new System.Drawing.Point(1295, 90);
            this.btnBlackModel.Name = "btnBlackModel";
            this.btnBlackModel.Size = new System.Drawing.Size(141, 37);
            this.btnBlackModel.TabIndex = 27;
            this.btnBlackModel.Text = "Modelo Negro";
            this.btnBlackModel.UseVisualStyleBackColor = false;
            this.btnBlackModel.Click += new System.EventHandler(this.btnBlackModel_Click);
            // 
            // btnGrayModel
            // 
            this.btnGrayModel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGrayModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrayModel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGrayModel.Location = new System.Drawing.Point(1295, 49);
            this.btnGrayModel.Name = "btnGrayModel";
            this.btnGrayModel.Size = new System.Drawing.Size(141, 35);
            this.btnGrayModel.TabIndex = 28;
            this.btnGrayModel.Text = "Modelo Gris";
            this.btnGrayModel.UseVisualStyleBackColor = false;
            this.btnGrayModel.Click += new System.EventHandler(this.btnGrayModel_Click);
            // 
            // chrtRendimiento
            // 
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chrtRendimiento.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chrtRendimiento.Legends.Add(legend1);
            this.chrtRendimiento.Location = new System.Drawing.Point(1170, 761);
            this.chrtRendimiento.Name = "chrtRendimiento";
            this.chrtRendimiento.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Correctas";
            this.chrtRendimiento.Series.Add(series1);
            this.chrtRendimiento.Size = new System.Drawing.Size(127, 93);
            this.chrtRendimiento.TabIndex = 29;
            this.chrtRendimiento.Text = "chart1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(415, 42);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 21);
            this.lblTime.TabIndex = 30;
            this.lblTime.Text = "00:00";
            // 
            // timer_cronometro
            // 
            this.timer_cronometro.Interval = 1000;
            this.timer_cronometro.Tick += new System.EventHandler(this.timer_cronometro_Tick);
            // 
            // Sistema_Vision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1448, 881);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.chrtRendimiento);
            this.Controls.Add(this.btnGrayModel);
            this.Controls.Add(this.btnBlackModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btn_iniciar_detener);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblPorcentajeRendimiento);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_conta_incorrectas);
            this.Controls.Add(this.lb_conta_correctas);
            this.Controls.Add(this.cb_modelo);
            this.Controls.Add(this.lb_modelo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(685, 413);
            this.Name = "Sistema_Vision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de vision ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sistema_Vision_FormClosing);
            this.Load += new System.EventHandler(this.Sistema_Vision_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRendimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_modelo;
        private System.Windows.Forms.ComboBox cb_modelo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_correcta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_conta_correctas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_conta_incorrectas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar_detener;
        private System.Windows.Forms.Label lb_fallas;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCalidad;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnChangeOper;
        public System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Label lblPruebaActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblClampTrigger;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblPiezaP;
        private System.Windows.Forms.Label lblParo;
        private System.Windows.Forms.Label lblCortina;
        private System.Windows.Forms.Label lblOpto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPorcentajeRendimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBlackModel;
        private System.Windows.Forms.Button btnGrayModel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRendimiento;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer_cronometro;
    }
}

