
namespace ControlLed
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.groupBoxLed = new System.Windows.Forms.GroupBox();
            this.pin6 = new System.Windows.Forms.PictureBox();
            this.pin5 = new System.Windows.Forms.PictureBox();
            this.pin4 = new System.Windows.Forms.PictureBox();
            this.pin2 = new System.Windows.Forms.PictureBox();
            this.pin1 = new System.Windows.Forms.PictureBox();
            this.pin3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLedOff = new System.Windows.Forms.Button();
            this.buttonLedOn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.conector = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPort.SuspendLayout();
            this.groupBoxLed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conector)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPort
            // 
            this.groupBoxPort.Controls.Add(this.buttonClose);
            this.groupBoxPort.Controls.Add(this.buttonOpen);
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
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(139, 128);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 45);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "DESCONECTAR";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.ForeColor = System.Drawing.Color.Black;
            this.buttonOpen.Location = new System.Drawing.Point(7, 128);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(120, 45);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "CONECTAR";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
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
            this.groupBoxLed.Controls.Add(this.pin6);
            this.groupBoxLed.Controls.Add(this.pin5);
            this.groupBoxLed.Controls.Add(this.pin4);
            this.groupBoxLed.Controls.Add(this.pin2);
            this.groupBoxLed.Controls.Add(this.pin1);
            this.groupBoxLed.Controls.Add(this.pin3);
            this.groupBoxLed.Controls.Add(this.pictureBox1);
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
            // pin6
            // 
            this.pin6.Image = global::ControlLed.Properties.Resources.green_led_off_md;
            this.pin6.Location = new System.Drawing.Point(116, 214);
            this.pin6.Margin = new System.Windows.Forms.Padding(2);
            this.pin6.Name = "pin6";
            this.pin6.Size = new System.Drawing.Size(47, 48);
            this.pin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin6.TabIndex = 6;
            this.pin6.TabStop = false;
            // 
            // pin5
            // 
            this.pin5.Image = global::ControlLed.Properties.Resources.green_led_off_md;
            this.pin5.Location = new System.Drawing.Point(116, 314);
            this.pin5.Margin = new System.Windows.Forms.Padding(2);
            this.pin5.Name = "pin5";
            this.pin5.Size = new System.Drawing.Size(47, 48);
            this.pin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin5.TabIndex = 5;
            this.pin5.TabStop = false;
            // 
            // pin4
            // 
            this.pin4.Image = global::ControlLed.Properties.Resources.green_led_off_md;
            this.pin4.Location = new System.Drawing.Point(209, 376);
            this.pin4.Margin = new System.Windows.Forms.Padding(2);
            this.pin4.Name = "pin4";
            this.pin4.Size = new System.Drawing.Size(47, 48);
            this.pin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin4.TabIndex = 4;
            this.pin4.TabStop = false;
            // 
            // pin2
            // 
            this.pin2.Image = global::ControlLed.Properties.Resources.green_led_off_md;
            this.pin2.Location = new System.Drawing.Point(309, 214);
            this.pin2.Margin = new System.Windows.Forms.Padding(2);
            this.pin2.Name = "pin2";
            this.pin2.Size = new System.Drawing.Size(47, 48);
            this.pin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin2.TabIndex = 3;
            this.pin2.TabStop = false;
            // 
            // pin1
            // 
            this.pin1.Image = global::ControlLed.Properties.Resources.green_led_off_md;
            this.pin1.Location = new System.Drawing.Point(209, 154);
            this.pin1.Margin = new System.Windows.Forms.Padding(2);
            this.pin1.Name = "pin1";
            this.pin1.Size = new System.Drawing.Size(47, 48);
            this.pin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin1.TabIndex = 2;
            this.pin1.TabStop = false;
            // 
            // pin3
            // 
            this.pin3.Image = global::ControlLed.Properties.Resources.green_led_off_md;
            this.pin3.Location = new System.Drawing.Point(308, 314);
            this.pin3.Margin = new System.Windows.Forms.Padding(2);
            this.pin3.Name = "pin3";
            this.pin3.Size = new System.Drawing.Size(47, 48);
            this.pin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin3.TabIndex = 0;
            this.pin3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlLed.Properties.Resources._6p;
            this.pictureBox1.Location = new System.Drawing.Point(44, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLedOff
            // 
            this.buttonLedOff.ForeColor = System.Drawing.Color.Black;
            this.buttonLedOff.Location = new System.Drawing.Point(44, 514);
            this.buttonLedOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLedOff.Name = "buttonLedOff";
            this.buttonLedOff.Size = new System.Drawing.Size(220, 60);
            this.buttonLedOff.TabIndex = 2;
            this.buttonLedOff.Text = "FIN TEST";
            this.buttonLedOff.UseVisualStyleBackColor = true;
            this.buttonLedOff.Click += new System.EventHandler(this.buttonLedOff_Click);
            // 
            // buttonLedOn
            // 
            this.buttonLedOn.ForeColor = System.Drawing.Color.Black;
            this.buttonLedOn.Location = new System.Drawing.Point(44, 453);
            this.buttonLedOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLedOn.Name = "buttonLedOn";
            this.buttonLedOn.Size = new System.Drawing.Size(220, 57);
            this.buttonLedOn.TabIndex = 1;
            this.buttonLedOn.Text = "INICIO TEST";
            this.buttonLedOn.UseVisualStyleBackColor = true;
            this.buttonLedOn.Click += new System.EventHandler(this.buttonLedOn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // conector
            // 
            this.conector.Image = global::ControlLed.Properties.Resources._6pinfull1;
            this.conector.Location = new System.Drawing.Point(12, 263);
            this.conector.Name = "conector";
            this.conector.Size = new System.Drawing.Size(275, 182);
            this.conector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conector.TabIndex = 6;
            this.conector.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "S.A. NAVAS ALMANZOR, CARLOS\r\nS.A. MUÑOZ HERNÁNDEZ, ANTONIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(777, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conector);
            this.Controls.Add(this.buttonLedOff);
            this.Controls.Add(this.groupBoxLed);
            this.Controls.Add(this.buttonLedOn);
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
            ((System.ComponentModel.ISupportInitialize)(this.pin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.GroupBox groupBoxLed;
        private System.Windows.Forms.PictureBox pin3;
        private System.Windows.Forms.Button buttonLedOff;
        private System.Windows.Forms.Button buttonLedOn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pin6;
        private System.Windows.Forms.PictureBox pin5;
        private System.Windows.Forms.PictureBox pin4;
        private System.Windows.Forms.PictureBox pin2;
        private System.Windows.Forms.PictureBox pin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox conector;
        private System.Windows.Forms.Label label1;
    }
}

