
namespace PinTester
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxPort = new System.Windows.Forms.GroupBox();
            this.botonDesconectar = new System.Windows.Forms.Button();
            this.botonConectar = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.groupBoxLed = new System.Windows.Forms.GroupBox();
            this.resultados = new System.Windows.Forms.CheckBox();
            this.pin105 = new System.Windows.Forms.PictureBox();
            this.pin1010 = new System.Windows.Forms.PictureBox();
            this.pin109 = new System.Windows.Forms.PictureBox();
            this.pin108 = new System.Windows.Forms.PictureBox();
            this.pin107 = new System.Windows.Forms.PictureBox();
            this.pin106 = new System.Windows.Forms.PictureBox();
            this.pin104 = new System.Windows.Forms.PictureBox();
            this.pin103 = new System.Windows.Forms.PictureBox();
            this.pin102 = new System.Windows.Forms.PictureBox();
            this.pin101 = new System.Windows.Forms.PictureBox();
            this.pin6 = new System.Windows.Forms.PictureBox();
            this.pin5 = new System.Windows.Forms.PictureBox();
            this.pin4 = new System.Windows.Forms.PictureBox();
            this.pin2 = new System.Windows.Forms.PictureBox();
            this.pin1 = new System.Windows.Forms.PictureBox();
            this.pin3 = new System.Windows.Forms.PictureBox();
            this.PinesConector = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.inicioTest = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ProducidoPor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conector = new System.Windows.Forms.PictureBox();
            this.groupBoxPort.SuspendLayout();
            this.groupBoxLed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pin105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin1010)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin109)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin108)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin107)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin106)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinesConector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conector)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPort
            // 
            this.groupBoxPort.Controls.Add(this.botonDesconectar);
            this.groupBoxPort.Controls.Add(this.botonConectar);
            this.groupBoxPort.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxPort.Controls.Add(this.labelBaud);
            this.groupBoxPort.Controls.Add(this.comboBoxComPort);
            this.groupBoxPort.Controls.Add(this.labelPort);
            this.groupBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPort.ForeColor = System.Drawing.Color.White;
            this.groupBoxPort.Location = new System.Drawing.Point(9, 12);
            this.groupBoxPort.Name = "groupBoxPort";
            this.groupBoxPort.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxPort.Size = new System.Drawing.Size(279, 202);
            this.groupBoxPort.TabIndex = 1;
            this.groupBoxPort.TabStop = false;
            this.groupBoxPort.Text = "CONFIGURACIÓN PUERTO COM";
            // 
            // botonDesconectar
            // 
            this.botonDesconectar.ForeColor = System.Drawing.Color.Black;
            this.botonDesconectar.Location = new System.Drawing.Point(139, 128);
            this.botonDesconectar.Margin = new System.Windows.Forms.Padding(2);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(133, 45);
            this.botonDesconectar.TabIndex = 10;
            this.botonDesconectar.Text = "DESCONECTAR";
            this.botonDesconectar.UseVisualStyleBackColor = true;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // botonConectar
            // 
            this.botonConectar.ForeColor = System.Drawing.Color.Black;
            this.botonConectar.Location = new System.Drawing.Point(7, 128);
            this.botonConectar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(120, 45);
            this.botonConectar.TabIndex = 9;
            this.botonConectar.Text = "CONECTAR";
            this.botonConectar.UseVisualStyleBackColor = true;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.Enabled = false;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(139, 77);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(116, 24);
            this.comboBoxBaudRate.TabIndex = 8;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(33, 80);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(101, 17);
            this.labelBaud.TabIndex = 7;
            this.labelBaud.Text = "BAUD RATE:";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(139, 32);
            this.comboBoxComPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(116, 24);
            this.comboBoxComPort.TabIndex = 6;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(18, 35);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(116, 17);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "PUERTO COM:";
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.Location = new System.Drawing.Point(9, 226);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(279, 29);
            this.progressBarConnection.TabIndex = 2;
            // 
            // groupBoxLed
            // 
            this.groupBoxLed.Controls.Add(this.resultados);
            this.groupBoxLed.Controls.Add(this.pin105);
            this.groupBoxLed.Controls.Add(this.pin1010);
            this.groupBoxLed.Controls.Add(this.pin109);
            this.groupBoxLed.Controls.Add(this.pin108);
            this.groupBoxLed.Controls.Add(this.pin107);
            this.groupBoxLed.Controls.Add(this.pin106);
            this.groupBoxLed.Controls.Add(this.pin104);
            this.groupBoxLed.Controls.Add(this.pin103);
            this.groupBoxLed.Controls.Add(this.pin102);
            this.groupBoxLed.Controls.Add(this.pin101);
            this.groupBoxLed.Controls.Add(this.pin6);
            this.groupBoxLed.Controls.Add(this.pin5);
            this.groupBoxLed.Controls.Add(this.pin4);
            this.groupBoxLed.Controls.Add(this.pin2);
            this.groupBoxLed.Controls.Add(this.pin1);
            this.groupBoxLed.Controls.Add(this.pin3);
            this.groupBoxLed.Controls.Add(this.PinesConector);
            this.groupBoxLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLed.ForeColor = System.Drawing.Color.White;
            this.groupBoxLed.Location = new System.Drawing.Point(296, 12);
            this.groupBoxLed.Name = "groupBoxLed";
            this.groupBoxLed.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxLed.Size = new System.Drawing.Size(466, 485);
            this.groupBoxLed.TabIndex = 5;
            this.groupBoxLed.TabStop = false;
            this.groupBoxLed.Text = "PIN TESTER";
            // 
            // resultados
            // 
            this.resultados.AutoSize = true;
            this.resultados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resultados.FlatAppearance.BorderSize = 4;
            this.resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultados.Location = new System.Drawing.Point(250, 447);
            this.resultados.Name = "resultados";
            this.resultados.Size = new System.Drawing.Size(193, 24);
            this.resultados.TabIndex = 22;
            this.resultados.Text = "Mantener resultados";
            this.resultados.UseVisualStyleBackColor = true;
            // 
            // pin105
            // 
            this.pin105.BackColor = System.Drawing.Color.White;
            this.pin105.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin105.Location = new System.Drawing.Point(208, 300);
            this.pin105.Margin = new System.Windows.Forms.Padding(2);
            this.pin105.Name = "pin105";
            this.pin105.Size = new System.Drawing.Size(54, 55);
            this.pin105.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin105.TabIndex = 21;
            this.pin105.TabStop = false;
            this.pin105.Visible = false;
            // 
            // pin1010
            // 
            this.pin1010.BackColor = System.Drawing.Color.White;
            this.pin1010.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin1010.Location = new System.Drawing.Point(161, 227);
            this.pin1010.Margin = new System.Windows.Forms.Padding(2);
            this.pin1010.Name = "pin1010";
            this.pin1010.Size = new System.Drawing.Size(54, 55);
            this.pin1010.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin1010.TabIndex = 20;
            this.pin1010.TabStop = false;
            this.pin1010.Visible = false;
            // 
            // pin109
            // 
            this.pin109.BackColor = System.Drawing.Color.White;
            this.pin109.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin109.Location = new System.Drawing.Point(247, 227);
            this.pin109.Margin = new System.Windows.Forms.Padding(2);
            this.pin109.Name = "pin109";
            this.pin109.Size = new System.Drawing.Size(54, 55);
            this.pin109.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin109.TabIndex = 19;
            this.pin109.TabStop = false;
            this.pin109.Visible = false;
            // 
            // pin108
            // 
            this.pin108.BackColor = System.Drawing.Color.White;
            this.pin108.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin108.Location = new System.Drawing.Point(119, 145);
            this.pin108.Margin = new System.Windows.Forms.Padding(2);
            this.pin108.Name = "pin108";
            this.pin108.Size = new System.Drawing.Size(54, 55);
            this.pin108.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin108.TabIndex = 18;
            this.pin108.TabStop = false;
            this.pin108.Visible = false;
            // 
            // pin107
            // 
            this.pin107.BackColor = System.Drawing.Color.White;
            this.pin107.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin107.Location = new System.Drawing.Point(79, 227);
            this.pin107.Margin = new System.Windows.Forms.Padding(2);
            this.pin107.Name = "pin107";
            this.pin107.Size = new System.Drawing.Size(54, 55);
            this.pin107.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin107.TabIndex = 17;
            this.pin107.TabStop = false;
            this.pin107.Visible = false;
            // 
            // pin106
            // 
            this.pin106.BackColor = System.Drawing.Color.White;
            this.pin106.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin106.Location = new System.Drawing.Point(119, 300);
            this.pin106.Margin = new System.Windows.Forms.Padding(2);
            this.pin106.Name = "pin106";
            this.pin106.Size = new System.Drawing.Size(54, 55);
            this.pin106.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin106.TabIndex = 16;
            this.pin106.TabStop = false;
            this.pin106.Visible = false;
            // 
            // pin104
            // 
            this.pin104.BackColor = System.Drawing.Color.White;
            this.pin104.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin104.Location = new System.Drawing.Point(294, 300);
            this.pin104.Margin = new System.Windows.Forms.Padding(2);
            this.pin104.Name = "pin104";
            this.pin104.Size = new System.Drawing.Size(54, 55);
            this.pin104.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin104.TabIndex = 15;
            this.pin104.TabStop = false;
            this.pin104.Visible = false;
            // 
            // pin103
            // 
            this.pin103.BackColor = System.Drawing.Color.White;
            this.pin103.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin103.Location = new System.Drawing.Point(335, 227);
            this.pin103.Margin = new System.Windows.Forms.Padding(2);
            this.pin103.Name = "pin103";
            this.pin103.Size = new System.Drawing.Size(54, 55);
            this.pin103.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin103.TabIndex = 14;
            this.pin103.TabStop = false;
            this.pin103.Visible = false;
            // 
            // pin102
            // 
            this.pin102.BackColor = System.Drawing.Color.White;
            this.pin102.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin102.Location = new System.Drawing.Point(294, 145);
            this.pin102.Margin = new System.Windows.Forms.Padding(2);
            this.pin102.Name = "pin102";
            this.pin102.Size = new System.Drawing.Size(54, 55);
            this.pin102.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin102.TabIndex = 13;
            this.pin102.TabStop = false;
            this.pin102.Visible = false;
            // 
            // pin101
            // 
            this.pin101.BackColor = System.Drawing.Color.White;
            this.pin101.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin101.Location = new System.Drawing.Point(206, 145);
            this.pin101.Margin = new System.Windows.Forms.Padding(2);
            this.pin101.Name = "pin101";
            this.pin101.Size = new System.Drawing.Size(54, 55);
            this.pin101.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin101.TabIndex = 12;
            this.pin101.TabStop = false;
            this.pin101.Visible = false;
            // 
            // pin6
            // 
            this.pin6.BackColor = System.Drawing.Color.White;
            this.pin6.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin6.Location = new System.Drawing.Point(114, 178);
            this.pin6.Margin = new System.Windows.Forms.Padding(2);
            this.pin6.Name = "pin6";
            this.pin6.Size = new System.Drawing.Size(54, 55);
            this.pin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin6.TabIndex = 6;
            this.pin6.TabStop = false;
            // 
            // pin5
            // 
            this.pin5.BackColor = System.Drawing.Color.White;
            this.pin5.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin5.Location = new System.Drawing.Point(114, 276);
            this.pin5.Margin = new System.Windows.Forms.Padding(2);
            this.pin5.Name = "pin5";
            this.pin5.Size = new System.Drawing.Size(54, 55);
            this.pin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin5.TabIndex = 5;
            this.pin5.TabStop = false;
            // 
            // pin4
            // 
            this.pin4.BackColor = System.Drawing.Color.White;
            this.pin4.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin4.Location = new System.Drawing.Point(208, 338);
            this.pin4.Margin = new System.Windows.Forms.Padding(2);
            this.pin4.Name = "pin4";
            this.pin4.Size = new System.Drawing.Size(54, 55);
            this.pin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin4.TabIndex = 4;
            this.pin4.TabStop = false;
            // 
            // pin2
            // 
            this.pin2.BackColor = System.Drawing.Color.White;
            this.pin2.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin2.Location = new System.Drawing.Point(305, 174);
            this.pin2.Margin = new System.Windows.Forms.Padding(2);
            this.pin2.Name = "pin2";
            this.pin2.Size = new System.Drawing.Size(54, 55);
            this.pin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin2.TabIndex = 3;
            this.pin2.TabStop = false;
            // 
            // pin1
            // 
            this.pin1.BackColor = System.Drawing.Color.White;
            this.pin1.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin1.Location = new System.Drawing.Point(208, 118);
            this.pin1.Margin = new System.Windows.Forms.Padding(2);
            this.pin1.Name = "pin1";
            this.pin1.Size = new System.Drawing.Size(54, 55);
            this.pin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin1.TabIndex = 2;
            this.pin1.TabStop = false;
            // 
            // pin3
            // 
            this.pin3.BackColor = System.Drawing.Color.White;
            this.pin3.Image = global::PinTester.Properties.Resources.green_led_off_md;
            this.pin3.Location = new System.Drawing.Point(305, 273);
            this.pin3.Margin = new System.Windows.Forms.Padding(2);
            this.pin3.Name = "pin3";
            this.pin3.Size = new System.Drawing.Size(54, 55);
            this.pin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin3.TabIndex = 0;
            this.pin3.TabStop = false;
            // 
            // PinesConector
            // 
            this.PinesConector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PinesConector.Image = global::PinTester.Properties.Resources._6p;
            this.PinesConector.Location = new System.Drawing.Point(45, 67);
            this.PinesConector.Name = "PinesConector";
            this.PinesConector.Size = new System.Drawing.Size(381, 357);
            this.PinesConector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PinesConector.TabIndex = 11;
            this.PinesConector.TabStop = false;
            // 
            // reset
            // 
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reset.FlatAppearance.BorderSize = 3;
            this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.reset.ForeColor = System.Drawing.Color.Black;
            this.reset.Location = new System.Drawing.Point(44, 525);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(220, 60);
            this.reset.TabIndex = 2;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.botonReset);
            // 
            // inicioTest
            // 
            this.inicioTest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.inicioTest.FlatAppearance.BorderSize = 3;
            this.inicioTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.inicioTest.ForeColor = System.Drawing.Color.Black;
            this.inicioTest.Location = new System.Drawing.Point(44, 459);
            this.inicioTest.Margin = new System.Windows.Forms.Padding(2);
            this.inicioTest.Name = "inicioTest";
            this.inicioTest.Size = new System.Drawing.Size(220, 57);
            this.inicioTest.TabIndex = 1;
            this.inicioTest.Text = "INICIO TEST";
            this.inicioTest.UseVisualStyleBackColor = true;
            this.inicioTest.Click += new System.EventHandler(this.inicioTest_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "S.A. NAVAS ALMANZOR, CARLOS\r\nS.A. MUÑOZ HERNÁNDEZ, ANTONIO";
            // 
            // ProducidoPor
            // 
            this.ProducidoPor.AutoSize = true;
            this.ProducidoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProducidoPor.Location = new System.Drawing.Point(293, 514);
            this.ProducidoPor.MaximumSize = new System.Drawing.Size(400, 0);
            this.ProducidoPor.Name = "ProducidoPor";
            this.ProducidoPor.Size = new System.Drawing.Size(344, 34);
            this.ProducidoPor.TabIndex = 8;
            this.ProducidoPor.Text = "Ingeniado, pensado, diseñado, montado, conectado, producido, programado, testeado" +
    " y explicado por:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PinTester.Properties.Resources.LogoABA;
            this.pictureBox1.Location = new System.Drawing.Point(676, 503);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // conector
            // 
            this.conector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.conector.Image = global::PinTester.Properties.Resources._6pinfull1;
            this.conector.Location = new System.Drawing.Point(12, 263);
            this.conector.Name = "conector";
            this.conector.Size = new System.Drawing.Size(275, 182);
            this.conector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conector.TabIndex = 6;
            this.conector.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(775, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProducidoPor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conector);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBoxLed);
            this.Controls.Add(this.inicioTest);
            this.Controls.Add(this.progressBarConnection);
            this.Controls.Add(this.groupBoxPort);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVIONIC PIN TESTER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPort.ResumeLayout(false);
            this.groupBoxPort.PerformLayout();
            this.groupBoxLed.ResumeLayout(false);
            this.groupBoxLed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pin105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin1010)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin109)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin108)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin107)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin106)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinesConector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        private System.Windows.Forms.Button botonDesconectar;
        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.GroupBox groupBoxLed;
        private System.Windows.Forms.PictureBox pin3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button inicioTest;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pin6;
        private System.Windows.Forms.PictureBox pin5;
        private System.Windows.Forms.PictureBox pin4;
        private System.Windows.Forms.PictureBox pin2;
        private System.Windows.Forms.PictureBox pin1;
        private System.Windows.Forms.PictureBox PinesConector;
        private System.Windows.Forms.PictureBox conector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pin101;
        private System.Windows.Forms.PictureBox pin1010;
        private System.Windows.Forms.PictureBox pin109;
        private System.Windows.Forms.PictureBox pin108;
        private System.Windows.Forms.PictureBox pin107;
        private System.Windows.Forms.PictureBox pin106;
        private System.Windows.Forms.PictureBox pin104;
        private System.Windows.Forms.PictureBox pin103;
        private System.Windows.Forms.PictureBox pin102;
        private System.Windows.Forms.PictureBox pin105;
        private System.Windows.Forms.Label ProducidoPor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox resultados;
    }
}

