namespace Invernadero
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesSerie = new System.Windows.Forms.Button();
            this.btnActSerie = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPuertoSerie = new System.Windows.Forms.ComboBox();
            this.grpManual = new System.Windows.Forms.GroupBox();
            this.grpCalefaccion = new System.Windows.Forms.GroupBox();
            this.radOffCalef = new System.Windows.Forms.RadioButton();
            this.radOnCalef = new System.Windows.Forms.RadioButton();
            this.grpAireAcon = new System.Windows.Forms.GroupBox();
            this.radOffAcond = new System.Windows.Forms.RadioButton();
            this.radOnAcond = new System.Windows.Forms.RadioButton();
            this.grpVentana = new System.Windows.Forms.GroupBox();
            this.radOffVent = new System.Windows.Forms.RadioButton();
            this.radOnVent = new System.Windows.Forms.RadioButton();
            this.grpBombaAire = new System.Windows.Forms.GroupBox();
            this.radOffBAire = new System.Windows.Forms.RadioButton();
            this.radOnBAire = new System.Windows.Forms.RadioButton();
            this.grpBombaAgua = new System.Windows.Forms.GroupBox();
            this.radOffBAgua = new System.Windows.Forms.RadioButton();
            this.radOnBAgua = new System.Windows.Forms.RadioButton();
            this.grpOperacion = new System.Windows.Forms.GroupBox();
            this.radAutonomo = new System.Windows.Forms.RadioButton();
            this.radManual = new System.Windows.Forms.RadioButton();
            this.grpAutonomo = new System.Windows.Forms.GroupBox();
            this.btnValPredet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numCerrarMin = new System.Windows.Forms.NumericUpDown();
            this.numAbrirMin = new System.Windows.Forms.NumericUpDown();
            this.numCerrarHrs = new System.Windows.Forms.NumericUpDown();
            this.numAbrirHrs = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numRanNivAgua = new System.Windows.Forms.NumericUpDown();
            this.numRanTemp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numNivAgua = new System.Windows.Forms.NumericUpDown();
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNivAct = new System.Windows.Forms.TextBox();
            this.txtTempAct = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtECom = new System.Windows.Forms.TextBox();
            this.txtEModo = new System.Windows.Forms.TextBox();
            this.txtENivAgua = new System.Windows.Forms.TextBox();
            this.txtETemp = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.sptArduino = new System.IO.Ports.SerialPort(this.components);
            this.tmrArduino = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpManual.SuspendLayout();
            this.grpCalefaccion.SuspendLayout();
            this.grpAireAcon.SuspendLayout();
            this.grpVentana.SuspendLayout();
            this.grpBombaAire.SuspendLayout();
            this.grpBombaAgua.SuspendLayout();
            this.grpOperacion.SuspendLayout();
            this.grpAutonomo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCerrarMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbrirMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCerrarHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbrirHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRanNivAgua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRanTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNivAgua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(697, 533);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.grpManual);
            this.tabPage2.Controls.Add(this.grpOperacion);
            this.tabPage2.Controls.Add(this.grpAutonomo);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuración";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDesSerie);
            this.groupBox2.Controls.Add(this.btnActSerie);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbPuertoSerie);
            this.groupBox2.Location = new System.Drawing.Point(448, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comunicación Serie";
            // 
            // btnDesSerie
            // 
            this.btnDesSerie.Location = new System.Drawing.Point(109, 59);
            this.btnDesSerie.Name = "btnDesSerie";
            this.btnDesSerie.Size = new System.Drawing.Size(75, 23);
            this.btnDesSerie.TabIndex = 3;
            this.btnDesSerie.Text = "Desactivar";
            this.btnDesSerie.UseVisualStyleBackColor = true;
            this.btnDesSerie.Click += new System.EventHandler(this.btnDesSerie_Click);
            // 
            // btnActSerie
            // 
            this.btnActSerie.Location = new System.Drawing.Point(18, 59);
            this.btnActSerie.Name = "btnActSerie";
            this.btnActSerie.Size = new System.Drawing.Size(75, 23);
            this.btnActSerie.TabIndex = 2;
            this.btnActSerie.Text = "Activar";
            this.btnActSerie.UseVisualStyleBackColor = true;
            this.btnActSerie.Click += new System.EventHandler(this.btnActSerie_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Puerto";
            // 
            // cmbPuertoSerie
            // 
            this.cmbPuertoSerie.FormattingEnabled = true;
            this.cmbPuertoSerie.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cmbPuertoSerie.Location = new System.Drawing.Point(59, 22);
            this.cmbPuertoSerie.Name = "cmbPuertoSerie";
            this.cmbPuertoSerie.Size = new System.Drawing.Size(82, 21);
            this.cmbPuertoSerie.TabIndex = 0;
            this.cmbPuertoSerie.SelectedIndexChanged += new System.EventHandler(this.cmbPuertoSerie_SelectedIndexChanged);
            // 
            // grpManual
            // 
            this.grpManual.Controls.Add(this.grpCalefaccion);
            this.grpManual.Controls.Add(this.grpAireAcon);
            this.grpManual.Controls.Add(this.grpVentana);
            this.grpManual.Controls.Add(this.grpBombaAire);
            this.grpManual.Controls.Add(this.grpBombaAgua);
            this.grpManual.Enabled = false;
            this.grpManual.Location = new System.Drawing.Point(4, 248);
            this.grpManual.Name = "grpManual";
            this.grpManual.Size = new System.Drawing.Size(762, 128);
            this.grpManual.TabIndex = 6;
            this.grpManual.TabStop = false;
            this.grpManual.Text = "Modo Manual";
            // 
            // grpCalefaccion
            // 
            this.grpCalefaccion.Controls.Add(this.radOffCalef);
            this.grpCalefaccion.Controls.Add(this.radOnCalef);
            this.grpCalefaccion.Location = new System.Drawing.Point(396, 30);
            this.grpCalefaccion.Name = "grpCalefaccion";
            this.grpCalefaccion.Size = new System.Drawing.Size(104, 72);
            this.grpCalefaccion.TabIndex = 9;
            this.grpCalefaccion.TabStop = false;
            this.grpCalefaccion.Text = "Calefacción";
            // 
            // radOffCalef
            // 
            this.radOffCalef.AutoSize = true;
            this.radOffCalef.Checked = true;
            this.radOffCalef.Location = new System.Drawing.Point(7, 44);
            this.radOffCalef.Name = "radOffCalef";
            this.radOffCalef.Size = new System.Drawing.Size(59, 17);
            this.radOffCalef.TabIndex = 1;
            this.radOffCalef.TabStop = true;
            this.radOffCalef.Text = "Apagar";
            this.radOffCalef.UseVisualStyleBackColor = true;
            this.radOffCalef.CheckedChanged += new System.EventHandler(this.radOffCalef_CheckedChanged);
            // 
            // radOnCalef
            // 
            this.radOnCalef.AutoSize = true;
            this.radOnCalef.Location = new System.Drawing.Point(7, 20);
            this.radOnCalef.Name = "radOnCalef";
            this.radOnCalef.Size = new System.Drawing.Size(71, 17);
            this.radOnCalef.TabIndex = 0;
            this.radOnCalef.Text = "Encender";
            this.radOnCalef.UseVisualStyleBackColor = true;
            this.radOnCalef.CheckedChanged += new System.EventHandler(this.radOnCalef_CheckedChanged);
            // 
            // grpAireAcon
            // 
            this.grpAireAcon.Controls.Add(this.radOffAcond);
            this.grpAireAcon.Controls.Add(this.radOnAcond);
            this.grpAireAcon.Location = new System.Drawing.Point(523, 30);
            this.grpAireAcon.Name = "grpAireAcon";
            this.grpAireAcon.Size = new System.Drawing.Size(121, 72);
            this.grpAireAcon.TabIndex = 8;
            this.grpAireAcon.TabStop = false;
            this.grpAireAcon.Text = "Aire Acondicionado ";
            // 
            // radOffAcond
            // 
            this.radOffAcond.AutoSize = true;
            this.radOffAcond.Checked = true;
            this.radOffAcond.Location = new System.Drawing.Point(7, 44);
            this.radOffAcond.Name = "radOffAcond";
            this.radOffAcond.Size = new System.Drawing.Size(59, 17);
            this.radOffAcond.TabIndex = 1;
            this.radOffAcond.TabStop = true;
            this.radOffAcond.Text = "Apagar";
            this.radOffAcond.UseVisualStyleBackColor = true;
            this.radOffAcond.CheckedChanged += new System.EventHandler(this.radOffAcond_CheckedChanged);
            // 
            // radOnAcond
            // 
            this.radOnAcond.AutoSize = true;
            this.radOnAcond.Location = new System.Drawing.Point(7, 20);
            this.radOnAcond.Name = "radOnAcond";
            this.radOnAcond.Size = new System.Drawing.Size(71, 17);
            this.radOnAcond.TabIndex = 0;
            this.radOnAcond.Text = "Encender";
            this.radOnAcond.UseVisualStyleBackColor = true;
            this.radOnAcond.CheckedChanged += new System.EventHandler(this.radOnAcond_CheckedChanged);
            // 
            // grpVentana
            // 
            this.grpVentana.Controls.Add(this.radOffVent);
            this.grpVentana.Controls.Add(this.radOnVent);
            this.grpVentana.Location = new System.Drawing.Point(268, 30);
            this.grpVentana.Name = "grpVentana";
            this.grpVentana.Size = new System.Drawing.Size(104, 72);
            this.grpVentana.TabIndex = 7;
            this.grpVentana.TabStop = false;
            this.grpVentana.Text = "Ventana";
            // 
            // radOffVent
            // 
            this.radOffVent.AutoSize = true;
            this.radOffVent.Checked = true;
            this.radOffVent.Location = new System.Drawing.Point(7, 44);
            this.radOffVent.Name = "radOffVent";
            this.radOffVent.Size = new System.Drawing.Size(53, 17);
            this.radOffVent.TabIndex = 1;
            this.radOffVent.TabStop = true;
            this.radOffVent.Text = "Cerrar";
            this.radOffVent.UseVisualStyleBackColor = true;
            this.radOffVent.CheckedChanged += new System.EventHandler(this.radOffVent_CheckedChanged);
            // 
            // radOnVent
            // 
            this.radOnVent.AutoSize = true;
            this.radOnVent.Location = new System.Drawing.Point(7, 20);
            this.radOnVent.Name = "radOnVent";
            this.radOnVent.Size = new System.Drawing.Size(46, 17);
            this.radOnVent.TabIndex = 0;
            this.radOnVent.Text = "Abrir";
            this.radOnVent.UseVisualStyleBackColor = true;
            this.radOnVent.CheckedChanged += new System.EventHandler(this.radOnVent_CheckedChanged);
            // 
            // grpBombaAire
            // 
            this.grpBombaAire.Controls.Add(this.radOffBAire);
            this.grpBombaAire.Controls.Add(this.radOnBAire);
            this.grpBombaAire.Location = new System.Drawing.Point(142, 30);
            this.grpBombaAire.Name = "grpBombaAire";
            this.grpBombaAire.Size = new System.Drawing.Size(104, 72);
            this.grpBombaAire.TabIndex = 2;
            this.grpBombaAire.TabStop = false;
            this.grpBombaAire.Text = "Bomba Aire";
            // 
            // radOffBAire
            // 
            this.radOffBAire.AutoSize = true;
            this.radOffBAire.Checked = true;
            this.radOffBAire.Location = new System.Drawing.Point(7, 44);
            this.radOffBAire.Name = "radOffBAire";
            this.radOffBAire.Size = new System.Drawing.Size(59, 17);
            this.radOffBAire.TabIndex = 1;
            this.radOffBAire.TabStop = true;
            this.radOffBAire.Text = "Apagar";
            this.radOffBAire.UseVisualStyleBackColor = true;
            this.radOffBAire.CheckedChanged += new System.EventHandler(this.radOffBAire_CheckedChanged);
            // 
            // radOnBAire
            // 
            this.radOnBAire.AutoSize = true;
            this.radOnBAire.Location = new System.Drawing.Point(7, 20);
            this.radOnBAire.Name = "radOnBAire";
            this.radOnBAire.Size = new System.Drawing.Size(71, 17);
            this.radOnBAire.TabIndex = 0;
            this.radOnBAire.Text = "Encender";
            this.radOnBAire.UseVisualStyleBackColor = true;
            this.radOnBAire.CheckedChanged += new System.EventHandler(this.radOnBAire_CheckedChanged);
            // 
            // grpBombaAgua
            // 
            this.grpBombaAgua.Controls.Add(this.radOffBAgua);
            this.grpBombaAgua.Controls.Add(this.radOnBAgua);
            this.grpBombaAgua.Location = new System.Drawing.Point(15, 30);
            this.grpBombaAgua.Name = "grpBombaAgua";
            this.grpBombaAgua.Size = new System.Drawing.Size(104, 72);
            this.grpBombaAgua.TabIndex = 0;
            this.grpBombaAgua.TabStop = false;
            this.grpBombaAgua.Text = "Bomba Agua";
            // 
            // radOffBAgua
            // 
            this.radOffBAgua.AutoSize = true;
            this.radOffBAgua.Checked = true;
            this.radOffBAgua.Location = new System.Drawing.Point(7, 44);
            this.radOffBAgua.Name = "radOffBAgua";
            this.radOffBAgua.Size = new System.Drawing.Size(59, 17);
            this.radOffBAgua.TabIndex = 1;
            this.radOffBAgua.TabStop = true;
            this.radOffBAgua.Text = "Apagar";
            this.radOffBAgua.UseVisualStyleBackColor = true;
            this.radOffBAgua.CheckedChanged += new System.EventHandler(this.radOffBAgua_CheckedChanged);
            // 
            // radOnBAgua
            // 
            this.radOnBAgua.AutoSize = true;
            this.radOnBAgua.Location = new System.Drawing.Point(7, 20);
            this.radOnBAgua.Name = "radOnBAgua";
            this.radOnBAgua.Size = new System.Drawing.Size(71, 17);
            this.radOnBAgua.TabIndex = 0;
            this.radOnBAgua.Text = "Encender";
            this.radOnBAgua.UseVisualStyleBackColor = true;
            this.radOnBAgua.CheckedChanged += new System.EventHandler(this.radOnBAgua_CheckedChanged);
            // 
            // grpOperacion
            // 
            this.grpOperacion.Controls.Add(this.radAutonomo);
            this.grpOperacion.Controls.Add(this.radManual);
            this.grpOperacion.Enabled = false;
            this.grpOperacion.Location = new System.Drawing.Point(237, 6);
            this.grpOperacion.Name = "grpOperacion";
            this.grpOperacion.Size = new System.Drawing.Size(186, 95);
            this.grpOperacion.TabIndex = 5;
            this.grpOperacion.TabStop = false;
            this.grpOperacion.Text = "Modo de Operación ";
            // 
            // radAutonomo
            // 
            this.radAutonomo.AutoSize = true;
            this.radAutonomo.Location = new System.Drawing.Point(17, 26);
            this.radAutonomo.Name = "radAutonomo";
            this.radAutonomo.Size = new System.Drawing.Size(73, 17);
            this.radAutonomo.TabIndex = 3;
            this.radAutonomo.Text = "Autónomo";
            this.radAutonomo.UseVisualStyleBackColor = true;
            this.radAutonomo.CheckedChanged += new System.EventHandler(this.radAutonomo_CheckedChanged);
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Location = new System.Drawing.Point(17, 53);
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(60, 17);
            this.radManual.TabIndex = 4;
            this.radManual.Text = "Manual";
            this.radManual.UseVisualStyleBackColor = true;
            this.radManual.CheckedChanged += new System.EventHandler(this.radManual_CheckedChanged);
            // 
            // grpAutonomo
            // 
            this.grpAutonomo.Controls.Add(this.btnValPredet);
            this.grpAutonomo.Controls.Add(this.label10);
            this.grpAutonomo.Controls.Add(this.label9);
            this.grpAutonomo.Controls.Add(this.numCerrarMin);
            this.grpAutonomo.Controls.Add(this.numAbrirMin);
            this.grpAutonomo.Controls.Add(this.numCerrarHrs);
            this.grpAutonomo.Controls.Add(this.numAbrirHrs);
            this.grpAutonomo.Controls.Add(this.label8);
            this.grpAutonomo.Controls.Add(this.label7);
            this.grpAutonomo.Controls.Add(this.numRanNivAgua);
            this.grpAutonomo.Controls.Add(this.numRanTemp);
            this.grpAutonomo.Controls.Add(this.label6);
            this.grpAutonomo.Controls.Add(this.label5);
            this.grpAutonomo.Controls.Add(this.numNivAgua);
            this.grpAutonomo.Controls.Add(this.numTemp);
            this.grpAutonomo.Controls.Add(this.label4);
            this.grpAutonomo.Controls.Add(this.label3);
            this.grpAutonomo.Enabled = false;
            this.grpAutonomo.Location = new System.Drawing.Point(6, 119);
            this.grpAutonomo.Name = "grpAutonomo";
            this.grpAutonomo.Size = new System.Drawing.Size(760, 122);
            this.grpAutonomo.TabIndex = 2;
            this.grpAutonomo.TabStop = false;
            this.grpAutonomo.Text = "Modo Autónomo";
            // 
            // btnValPredet
            // 
            this.btnValPredet.Location = new System.Drawing.Point(9, 88);
            this.btnValPredet.Name = "btnValPredet";
            this.btnValPredet.Size = new System.Drawing.Size(175, 23);
            this.btnValPredet.TabIndex = 19;
            this.btnValPredet.Text = "Valores Predeterminados ";
            this.btnValPredet.UseVisualStyleBackColor = true;
            this.btnValPredet.Click += new System.EventHandler(this.btnValPredet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "MM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "HH";
            // 
            // numCerrarMin
            // 
            this.numCerrarMin.Location = new System.Drawing.Point(573, 57);
            this.numCerrarMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numCerrarMin.Name = "numCerrarMin";
            this.numCerrarMin.Size = new System.Drawing.Size(35, 20);
            this.numCerrarMin.TabIndex = 16;
            // 
            // numAbrirMin
            // 
            this.numAbrirMin.Location = new System.Drawing.Point(573, 28);
            this.numAbrirMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numAbrirMin.Name = "numAbrirMin";
            this.numAbrirMin.Size = new System.Drawing.Size(35, 20);
            this.numAbrirMin.TabIndex = 15;
            // 
            // numCerrarHrs
            // 
            this.numCerrarHrs.Location = new System.Drawing.Point(532, 57);
            this.numCerrarHrs.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numCerrarHrs.Name = "numCerrarHrs";
            this.numCerrarHrs.Size = new System.Drawing.Size(35, 20);
            this.numCerrarHrs.TabIndex = 14;
            this.numCerrarHrs.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numAbrirHrs
            // 
            this.numAbrirHrs.Location = new System.Drawing.Point(532, 28);
            this.numAbrirHrs.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numAbrirHrs.Name = "numAbrirHrs";
            this.numAbrirHrs.Size = new System.Drawing.Size(35, 20);
            this.numAbrirHrs.TabIndex = 13;
            this.numAbrirHrs.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cerrar Ventana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Abrir Ventana";
            // 
            // numRanNivAgua
            // 
            this.numRanNivAgua.Location = new System.Drawing.Point(299, 57);
            this.numRanNivAgua.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numRanNivAgua.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRanNivAgua.Name = "numRanNivAgua";
            this.numRanNivAgua.Size = new System.Drawing.Size(81, 20);
            this.numRanNivAgua.TabIndex = 10;
            this.numRanNivAgua.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numRanTemp
            // 
            this.numRanTemp.DecimalPlaces = 2;
            this.numRanTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRanTemp.Location = new System.Drawing.Point(299, 28);
            this.numRanTemp.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRanTemp.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numRanTemp.Name = "numRanTemp";
            this.numRanTemp.Size = new System.Drawing.Size(81, 20);
            this.numRanTemp.TabIndex = 9;
            this.numRanTemp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rango (±%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rango (±°C)";
            // 
            // numNivAgua
            // 
            this.numNivAgua.Location = new System.Drawing.Point(103, 57);
            this.numNivAgua.Name = "numNivAgua";
            this.numNivAgua.Size = new System.Drawing.Size(81, 20);
            this.numNivAgua.TabIndex = 6;
            this.numNivAgua.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numTemp
            // 
            this.numTemp.DecimalPlaces = 2;
            this.numTemp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numTemp.Location = new System.Drawing.Point(103, 28);
            this.numTemp.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numTemp.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(81, 20);
            this.numTemp.TabIndex = 5;
            this.numTemp.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nivel de Agua (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperatura (°C)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNivAct);
            this.groupBox1.Controls.Add(this.txtTempAct);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores Actuales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nivel de Agua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura";
            // 
            // txtNivAct
            // 
            this.txtNivAct.BackColor = System.Drawing.Color.White;
            this.txtNivAct.Location = new System.Drawing.Point(98, 55);
            this.txtNivAct.Name = "txtNivAct";
            this.txtNivAct.ReadOnly = true;
            this.txtNivAct.Size = new System.Drawing.Size(100, 20);
            this.txtNivAct.TabIndex = 1;
            // 
            // txtTempAct
            // 
            this.txtTempAct.BackColor = System.Drawing.Color.White;
            this.txtTempAct.Location = new System.Drawing.Point(98, 29);
            this.txtTempAct.Name = "txtTempAct";
            this.txtTempAct.ReadOnly = true;
            this.txtTempAct.Size = new System.Drawing.Size(100, 20);
            this.txtTempAct.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(245)))), ((int)(((byte)(152)))));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtECom);
            this.tabPage1.Controls.Add(this.txtEModo);
            this.tabPage1.Controls.Add(this.txtENivAgua);
            this.tabPage1.Controls.Add(this.txtETemp);
            this.tabPage1.Controls.Add(this.txtFecha);
            this.tabPage1.Controls.Add(this.txtHora);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            // 
            // txtECom
            // 
            this.txtECom.BackColor = System.Drawing.Color.Turquoise;
            this.txtECom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtECom.Font = new System.Drawing.Font("Digitalism", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECom.Location = new System.Drawing.Point(430, 221);
            this.txtECom.Multiline = true;
            this.txtECom.Name = "txtECom";
            this.txtECom.ReadOnly = true;
            this.txtECom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtECom.Size = new System.Drawing.Size(284, 32);
            this.txtECom.TabIndex = 6;
            this.txtECom.Text = "COMUNICACION DESACTIVADA";
            // 
            // txtEModo
            // 
            this.txtEModo.BackColor = System.Drawing.Color.Turquoise;
            this.txtEModo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEModo.Font = new System.Drawing.Font("Digitalism", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEModo.Location = new System.Drawing.Point(430, 259);
            this.txtEModo.Multiline = true;
            this.txtEModo.Name = "txtEModo";
            this.txtEModo.ReadOnly = true;
            this.txtEModo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEModo.Size = new System.Drawing.Size(284, 32);
            this.txtEModo.TabIndex = 5;
            // 
            // txtENivAgua
            // 
            this.txtENivAgua.BackColor = System.Drawing.Color.Turquoise;
            this.txtENivAgua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtENivAgua.Font = new System.Drawing.Font("Digitalism", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENivAgua.Location = new System.Drawing.Point(60, 259);
            this.txtENivAgua.Multiline = true;
            this.txtENivAgua.Name = "txtENivAgua";
            this.txtENivAgua.ReadOnly = true;
            this.txtENivAgua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtENivAgua.Size = new System.Drawing.Size(221, 32);
            this.txtENivAgua.TabIndex = 4;
            // 
            // txtETemp
            // 
            this.txtETemp.BackColor = System.Drawing.Color.Turquoise;
            this.txtETemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtETemp.Font = new System.Drawing.Font("Digitalism", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtETemp.Location = new System.Drawing.Point(60, 221);
            this.txtETemp.Multiline = true;
            this.txtETemp.Name = "txtETemp";
            this.txtETemp.ReadOnly = true;
            this.txtETemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtETemp.Size = new System.Drawing.Size(221, 32);
            this.txtETemp.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.Turquoise;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Digitalism", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(189, 155);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(377, 37);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.Turquoise;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Font = new System.Drawing.Font("Digital-7", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(51, 76);
            this.txtHora.Multiline = true;
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(675, 223);
            this.txtHora.TabIndex = 1;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(710, 50);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sistema Controlador de Invernadero ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // tmrArduino
            // 
            this.tmrArduino.Interval = 1000;
            this.tmrArduino.Tick += new System.EventHandler(this.tmrArduino_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Invernadero.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(277, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Invernadero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpManual.ResumeLayout(false);
            this.grpCalefaccion.ResumeLayout(false);
            this.grpCalefaccion.PerformLayout();
            this.grpAireAcon.ResumeLayout(false);
            this.grpAireAcon.PerformLayout();
            this.grpVentana.ResumeLayout(false);
            this.grpVentana.PerformLayout();
            this.grpBombaAire.ResumeLayout(false);
            this.grpBombaAire.PerformLayout();
            this.grpBombaAgua.ResumeLayout(false);
            this.grpBombaAgua.PerformLayout();
            this.grpOperacion.ResumeLayout(false);
            this.grpOperacion.PerformLayout();
            this.grpAutonomo.ResumeLayout(false);
            this.grpAutonomo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCerrarMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbrirMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCerrarHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbrirHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRanNivAgua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRanTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNivAgua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radManual;
        private System.Windows.Forms.RadioButton radAutonomo;
        private System.Windows.Forms.GroupBox grpAutonomo;
        private System.Windows.Forms.NumericUpDown numRanNivAgua;
        private System.Windows.Forms.NumericUpDown numRanTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numNivAgua;
        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNivAct;
        private System.Windows.Forms.TextBox txtTempAct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox grpOperacion;
        private System.Windows.Forms.GroupBox grpManual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numAbrirHrs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCerrarMin;
        private System.Windows.Forms.NumericUpDown numAbrirMin;
        private System.Windows.Forms.NumericUpDown numCerrarHrs;
        private System.Windows.Forms.Button btnValPredet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpBombaAgua;
        private System.Windows.Forms.GroupBox grpVentana;
        private System.Windows.Forms.RadioButton radOffVent;
        private System.Windows.Forms.RadioButton radOnVent;
        private System.Windows.Forms.GroupBox grpBombaAire;
        private System.Windows.Forms.RadioButton radOffBAire;
        private System.Windows.Forms.RadioButton radOnBAire;
        private System.Windows.Forms.RadioButton radOffBAgua;
        private System.Windows.Forms.RadioButton radOnBAgua;
        private System.Windows.Forms.GroupBox grpCalefaccion;
        private System.Windows.Forms.RadioButton radOffCalef;
        private System.Windows.Forms.RadioButton radOnCalef;
        private System.Windows.Forms.GroupBox grpAireAcon;
        private System.Windows.Forms.RadioButton radOffAcond;
        private System.Windows.Forms.RadioButton radOnAcond;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPuertoSerie;
        private System.Windows.Forms.Button btnDesSerie;
        private System.Windows.Forms.Button btnActSerie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.TextBox txtETemp;
        private System.Windows.Forms.TextBox txtENivAgua;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtEModo;
        private System.Windows.Forms.TextBox txtECom;
        private System.IO.Ports.SerialPort sptArduino;
        private System.Windows.Forms.Timer tmrArduino;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

