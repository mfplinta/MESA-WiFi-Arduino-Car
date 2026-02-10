namespace MESA_WiFi_Arduino_Car
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbController = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnConnectCar = new System.Windows.Forms.Button();
            this.gbLED = new System.Windows.Forms.GroupBox();
            this.tbtnRainbowMode = new System.Windows.Forms.CheckBox();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.gbMotor = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRightMotor = new System.Windows.Forms.TrackBar();
            this.tbLeftMotor = new System.Windows.Forms.TrackBar();
            this.gbCarControlling = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnableControl = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnToggleServer = new System.Windows.Forms.Button();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCarIp = new System.Windows.Forms.TextBox();
            this.lblCarStatus = new System.Windows.Forms.Label();
            this.txtCarPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pbThrottle = new System.Windows.Forms.ProgressBar();
            this.pbReverse = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnQueryControllers = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.ProgressBar();
            this.pbRight = new System.Windows.Forms.ProgressBar();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbLED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            this.gbMotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMotor)).BeginInit();
            this.gbCarControlling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHS Arduino Wi-Fi Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Controller (F310):";
            // 
            // cbController
            // 
            this.cbController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbController.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbController.FormattingEnabled = true;
            this.cbController.Location = new System.Drawing.Point(150, 107);
            this.cbController.Name = "cbController";
            this.cbController.Size = new System.Drawing.Size(460, 23);
            this.cbController.TabIndex = 3;
            this.cbController.DataSourceChanged += new System.EventHandler(this.CbController_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCarPort);
            this.groupBox1.Controls.Add(this.lblCarStatus);
            this.groupBox1.Controls.Add(this.txtCarIp);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblServerStatus);
            this.groupBox1.Controls.Add(this.btnToggleServer);
            this.groupBox1.Controls.Add(this.lblIp);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnConnectCar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection status";
            // 
            // lblIp
            // 
            this.lblIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.Location = new System.Drawing.Point(53, 67);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(34, 20);
            this.lblIp.TabIndex = 3;
            this.lblIp.Text = "n/a";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Computer";
            // 
            // btnConnectCar
            // 
            this.btnConnectCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnectCar.Location = new System.Drawing.Point(200, 148);
            this.btnConnectCar.Name = "btnConnectCar";
            this.btnConnectCar.Size = new System.Drawing.Size(160, 35);
            this.btnConnectCar.TabIndex = 1;
            this.btnConnectCar.Text = "Connect";
            this.btnConnectCar.UseVisualStyleBackColor = true;
            this.btnConnectCar.Click += new System.EventHandler(this.BtnConnectCar_Click);
            // 
            // gbLED
            // 
            this.gbLED.Controls.Add(this.tbtnRainbowMode);
            this.gbLED.Controls.Add(this.pbColor);
            this.gbLED.Controls.Add(this.tbBlue);
            this.gbLED.Controls.Add(this.label8);
            this.gbLED.Controls.Add(this.tbGreen);
            this.gbLED.Controls.Add(this.label7);
            this.gbLED.Controls.Add(this.tbRed);
            this.gbLED.Controls.Add(this.label6);
            this.gbLED.Enabled = false;
            this.gbLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLED.Location = new System.Drawing.Point(16, 347);
            this.gbLED.Name = "gbLED";
            this.gbLED.Size = new System.Drawing.Size(194, 217);
            this.gbLED.TabIndex = 5;
            this.gbLED.TabStop = false;
            this.gbLED.Text = "LED control";
            // 
            // tbtnRainbowMode
            // 
            this.tbtnRainbowMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.tbtnRainbowMode.Checked = true;
            this.tbtnRainbowMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbtnRainbowMode.Location = new System.Drawing.Point(10, 176);
            this.tbtnRainbowMode.Name = "tbtnRainbowMode";
            this.tbtnRainbowMode.Size = new System.Drawing.Size(173, 35);
            this.tbtnRainbowMode.TabIndex = 7;
            this.tbtnRainbowMode.Text = "Rainbow mode";
            this.tbtnRainbowMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbtnRainbowMode.UseVisualStyleBackColor = true;
            this.tbtnRainbowMode.CheckedChanged += new System.EventHandler(this.TbtnRainbowMode_CheckedChanged);
            // 
            // tbBlue
            // 
            this.tbBlue.AutoSize = false;
            this.tbBlue.Enabled = false;
            this.tbBlue.Location = new System.Drawing.Point(37, 105);
            this.tbBlue.Maximum = 1024;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(151, 20);
            this.tbBlue.TabIndex = 5;
            this.tbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBlue.Scroll += new System.EventHandler(this.ColorSlider_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "B:";
            // 
            // tbGreen
            // 
            this.tbGreen.AutoSize = false;
            this.tbGreen.Enabled = false;
            this.tbGreen.Location = new System.Drawing.Point(37, 69);
            this.tbGreen.Maximum = 1024;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(151, 20);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGreen.Scroll += new System.EventHandler(this.ColorSlider_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "G:";
            // 
            // tbRed
            // 
            this.tbRed.AutoSize = false;
            this.tbRed.Enabled = false;
            this.tbRed.Location = new System.Drawing.Point(37, 32);
            this.tbRed.Maximum = 1024;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(151, 20);
            this.tbRed.TabIndex = 1;
            this.tbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbRed.Scroll += new System.EventHandler(this.ColorSlider_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "R:";
            // 
            // gbMotor
            // 
            this.gbMotor.Controls.Add(this.label11);
            this.gbMotor.Controls.Add(this.label10);
            this.gbMotor.Controls.Add(this.tbRightMotor);
            this.gbMotor.Controls.Add(this.tbLeftMotor);
            this.gbMotor.Enabled = false;
            this.gbMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMotor.Location = new System.Drawing.Point(216, 347);
            this.gbMotor.Name = "gbMotor";
            this.gbMotor.Size = new System.Drawing.Size(210, 217);
            this.gbMotor.TabIndex = 6;
            this.gbMotor.TabStop = false;
            this.gbMotor.Text = "Motor testing";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "R";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "L";
            // 
            // tbRightMotor
            // 
            this.tbRightMotor.AutoSize = false;
            this.tbRightMotor.Location = new System.Drawing.Point(126, 105);
            this.tbRightMotor.Maximum = 1024;
            this.tbRightMotor.Name = "tbRightMotor";
            this.tbRightMotor.Size = new System.Drawing.Size(61, 20);
            this.tbRightMotor.TabIndex = 7;
            this.tbRightMotor.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbRightMotor.Scroll += new System.EventHandler(this.Motors_Scroll);
            // 
            // tbLeftMotor
            // 
            this.tbLeftMotor.AutoSize = false;
            this.tbLeftMotor.Location = new System.Drawing.Point(18, 105);
            this.tbLeftMotor.Maximum = 1024;
            this.tbLeftMotor.Name = "tbLeftMotor";
            this.tbLeftMotor.Size = new System.Drawing.Size(61, 20);
            this.tbLeftMotor.TabIndex = 6;
            this.tbLeftMotor.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbLeftMotor.Scroll += new System.EventHandler(this.Motors_Scroll);
            // 
            // gbCarControlling
            // 
            this.gbCarControlling.Controls.Add(this.label20);
            this.gbCarControlling.Controls.Add(this.label19);
            this.gbCarControlling.Controls.Add(this.pbRight);
            this.gbCarControlling.Controls.Add(this.pbLeft);
            this.gbCarControlling.Controls.Add(this.pictureBox3);
            this.gbCarControlling.Controls.Add(this.pbReverse);
            this.gbCarControlling.Controls.Add(this.pbThrottle);
            this.gbCarControlling.Controls.Add(this.label18);
            this.gbCarControlling.Controls.Add(this.label17);
            this.gbCarControlling.Controls.Add(this.label5);
            this.gbCarControlling.Controls.Add(this.label4);
            this.gbCarControlling.Controls.Add(this.btnEnableControl);
            this.gbCarControlling.Enabled = false;
            this.gbCarControlling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarControlling.Location = new System.Drawing.Point(432, 347);
            this.gbCarControlling.Name = "gbCarControlling";
            this.gbCarControlling.Size = new System.Drawing.Size(212, 217);
            this.gbCarControlling.TabIndex = 7;
            this.gbCarControlling.TabStop = false;
            this.gbCarControlling.Text = "Car controlling";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "n/a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current latency:";
            // 
            // btnEnableControl
            // 
            this.btnEnableControl.Location = new System.Drawing.Point(6, 176);
            this.btnEnableControl.Name = "btnEnableControl";
            this.btnEnableControl.Size = new System.Drawing.Size(200, 35);
            this.btnEnableControl.TabIndex = 0;
            this.btnEnableControl.Text = "Enable";
            this.btnEnableControl.UseVisualStyleBackColor = true;
            this.btnEnableControl.Click += new System.EventHandler(this.BtnEnableControl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Engineered by Matheus Plinta (mfplinta@gmail.com)";
            // 
            // btnToggleServer
            // 
            this.btnToggleServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToggleServer.Location = new System.Drawing.Point(10, 148);
            this.btnToggleServer.Name = "btnToggleServer";
            this.btnToggleServer.Size = new System.Drawing.Size(140, 35);
            this.btnToggleServer.TabIndex = 4;
            this.btnToggleServer.Text = "Stop Listener";
            this.btnToggleServer.UseVisualStyleBackColor = true;
            this.btnToggleServer.Click += new System.EventHandler(this.BtnToggleServer_Click);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServerStatus.BackColor = System.Drawing.Color.GreenYellow;
            this.lblServerStatus.Location = new System.Drawing.Point(422, 63);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(200, 29);
            this.lblServerStatus.TabIndex = 5;
            this.lblServerStatus.Text = "Server enabled";
            this.lblServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(196, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Car";
            // 
            // txtCarIp
            // 
            this.txtCarIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCarIp.Location = new System.Drawing.Point(241, 64);
            this.txtCarIp.Name = "txtCarIp";
            this.txtCarIp.Size = new System.Drawing.Size(119, 26);
            this.txtCarIp.TabIndex = 7;
            this.txtCarIp.Text = "192.168.4.1";
            // 
            // lblCarStatus
            // 
            this.lblCarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCarStatus.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCarStatus.Location = new System.Drawing.Point(422, 104);
            this.lblCarStatus.Name = "lblCarStatus";
            this.lblCarStatus.Size = new System.Drawing.Size(200, 29);
            this.lblCarStatus.TabIndex = 8;
            this.lblCarStatus.Text = "Car disconnected";
            this.lblCarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCarPort
            // 
            this.txtCarPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCarPort.Location = new System.Drawing.Point(241, 99);
            this.txtCarPort.Name = "txtCarPort";
            this.txtCarPort.Size = new System.Drawing.Size(58, 26);
            this.txtCarPort.TabIndex = 10;
            this.txtCarPort.Text = "2001";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Location = new System.Drawing.Point(57, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 26);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "2001";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "IP:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Port:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "IP:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "Throttle:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "Reverse:";
            // 
            // pbThrottle
            // 
            this.pbThrottle.Location = new System.Drawing.Point(64, 37);
            this.pbThrottle.Maximum = 1024;
            this.pbThrottle.Name = "pbThrottle";
            this.pbThrottle.Size = new System.Drawing.Size(142, 10);
            this.pbThrottle.TabIndex = 5;
            // 
            // pbReverse
            // 
            this.pbReverse.Location = new System.Drawing.Point(64, 58);
            this.pbReverse.Maximum = 1024;
            this.pbReverse.Name = "pbReverse";
            this.pbReverse.Size = new System.Drawing.Size(142, 10);
            this.pbReverse.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MESA_WiFi_Arduino_Car.Properties.Resources.mesa_logo;
            this.pictureBox2.Location = new System.Drawing.Point(116, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnQueryControllers
            // 
            this.btnQueryControllers.Image = global::MESA_WiFi_Arduino_Car.Properties.Resources.Reload_icon;
            this.btnQueryControllers.Location = new System.Drawing.Point(616, 107);
            this.btnQueryControllers.Name = "btnQueryControllers";
            this.btnQueryControllers.Size = new System.Drawing.Size(31, 23);
            this.btnQueryControllers.TabIndex = 9;
            this.btnQueryControllers.UseVisualStyleBackColor = true;
            this.btnQueryControllers.Click += new System.EventHandler(this.BtnQueryControllers_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MESA_WiFi_Arduino_Car.Properties.Resources.Joystick_icon;
            this.pictureBox3.Location = new System.Drawing.Point(99, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pbColor
            // 
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColor.Location = new System.Drawing.Point(10, 131);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(173, 23);
            this.pbColor.TabIndex = 6;
            this.pbColor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MESA_WiFi_Arduino_Car.Properties.Resources._12554_resized;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbLeft
            // 
            this.pbLeft.Location = new System.Drawing.Point(10, 97);
            this.pbLeft.Maximum = 1024;
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(84, 10);
            this.pbLeft.TabIndex = 8;
            // 
            // pbRight
            // 
            this.pbRight.Location = new System.Drawing.Point(121, 97);
            this.pbRight.Maximum = 1024;
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(85, 10);
            this.pbRight.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 15);
            this.label19.TabIndex = 10;
            this.label19.Text = "Left";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(121, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Right";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 605);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnQueryControllers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbCarControlling);
            this.Controls.Add(this.gbMotor);
            this.Controls.Add(this.gbLED);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbController);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHS Arduino Wi-Fi Car - Control Panel";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbLED.ResumeLayout(false);
            this.gbLED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            this.gbMotor.ResumeLayout(false);
            this.gbMotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMotor)).EndInit();
            this.gbCarControlling.ResumeLayout(false);
            this.gbCarControlling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbController;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnectCar;
        private System.Windows.Forms.GroupBox gbLED;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbMotor;
        private System.Windows.Forms.GroupBox gbCarControlling;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnableControl;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnQueryControllers;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbRightMotor;
        private System.Windows.Forms.TrackBar tbLeftMotor;
        private System.Windows.Forms.CheckBox tbtnRainbowMode;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnToggleServer;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.TextBox txtCarIp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCarStatus;
        private System.Windows.Forms.TextBox txtCarPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar pbReverse;
        private System.Windows.Forms.ProgressBar pbThrottle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar pbRight;
        private System.Windows.Forms.ProgressBar pbLeft;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}

