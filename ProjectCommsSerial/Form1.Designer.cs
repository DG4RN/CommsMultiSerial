namespace ProjectCommsMultiSerial
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.rtbIncomingData = new System.Windows.Forms.RichTextBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboHandShaking = new System.Windows.Forms.ComboBox();
            this.lblBreakStatus = new System.Windows.Forms.Label();
            this.lblCTSStatus = new System.Windows.Forms.Label();
            this.lblDSRStatus = new System.Windows.Forms.Label();
            this.lblRIStatus = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPortState = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.rtbOutgoing = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatalength = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrequenzPA = new System.Windows.Forms.Label();
            this.rtbPort3RXBox = new System.Windows.Forms.RichTextBox();
            this.btn2ndHello = new System.Windows.Forms.Button();
            this.btn2ndPortState = new System.Windows.Forms.Button();
            this.btn2ndGetSerialPorts = new System.Windows.Forms.Button();
            this.rtb2ndOutgoing = new System.Windows.Forms.RichTextBox();
            this.rtb2ndIncomingData = new System.Windows.Forms.RichTextBox();
            this.cbo2ndHandShaking = new System.Windows.Forms.ComboBox();
            this.cbo2ndParity = new System.Windows.Forms.ComboBox();
            this.cbo2ndStopBits = new System.Windows.Forms.ComboBox();
            this.cbo2ndPort = new System.Windows.Forms.ComboBox();
            this.cbo2ndBaudRate = new System.Windows.Forms.ComboBox();
            this.cbo2ndDataBits = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(48, 102);
            this.btnGetSerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(100, 28);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // rtbIncomingData
            // 
            this.rtbIncomingData.Location = new System.Drawing.Point(9, 244);
            this.rtbIncomingData.Margin = new System.Windows.Forms.Padding(4);
            this.rtbIncomingData.Name = "rtbIncomingData";
            this.rtbIncomingData.Size = new System.Drawing.Size(133, 117);
            this.rtbIncomingData.TabIndex = 1;
            this.rtbIncomingData.Text = "";
            this.rtbIncomingData.TextChanged += new System.EventHandler(this.rtbIncomingData_TextChanged);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(264, 11);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(160, 24);
            this.cboPorts.TabIndex = 2;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(264, 52);
            this.cboBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(160, 24);
            this.cboBaudRate.TabIndex = 3;
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(264, 81);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(160, 24);
            this.cboDataBits.TabIndex = 4;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(264, 113);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(160, 24);
            this.cboStopBits.TabIndex = 5;
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(264, 145);
            this.cboParity.Margin = new System.Windows.Forms.Padding(4);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(160, 24);
            this.cboParity.TabIndex = 6;
            // 
            // cboHandShaking
            // 
            this.cboHandShaking.FormattingEnabled = true;
            this.cboHandShaking.Location = new System.Drawing.Point(264, 181);
            this.cboHandShaking.Margin = new System.Windows.Forms.Padding(4);
            this.cboHandShaking.Name = "cboHandShaking";
            this.cboHandShaking.Size = new System.Drawing.Size(160, 24);
            this.cboHandShaking.TabIndex = 7;
            // 
            // lblBreakStatus
            // 
            this.lblBreakStatus.AutoSize = true;
            this.lblBreakStatus.Location = new System.Drawing.Point(16, 377);
            this.lblBreakStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreakStatus.Name = "lblBreakStatus";
            this.lblBreakStatus.Size = new System.Drawing.Size(43, 16);
            this.lblBreakStatus.TabIndex = 8;
            this.lblBreakStatus.Text = "Break";
            // 
            // lblCTSStatus
            // 
            this.lblCTSStatus.AutoSize = true;
            this.lblCTSStatus.Location = new System.Drawing.Point(76, 377);
            this.lblCTSStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTSStatus.Name = "lblCTSStatus";
            this.lblCTSStatus.Size = new System.Drawing.Size(34, 16);
            this.lblCTSStatus.TabIndex = 9;
            this.lblCTSStatus.Text = "CTS";
            // 
            // lblDSRStatus
            // 
            this.lblDSRStatus.AutoSize = true;
            this.lblDSRStatus.Location = new System.Drawing.Point(127, 377);
            this.lblDSRStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDSRStatus.Name = "lblDSRStatus";
            this.lblDSRStatus.Size = new System.Drawing.Size(36, 16);
            this.lblDSRStatus.TabIndex = 10;
            this.lblDSRStatus.Text = "DSR";
            // 
            // lblRIStatus
            // 
            this.lblRIStatus.AutoSize = true;
            this.lblRIStatus.Location = new System.Drawing.Point(176, 377);
            this.lblRIStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRIStatus.Name = "lblRIStatus";
            this.lblRIStatus.Size = new System.Drawing.Size(20, 16);
            this.lblRIStatus.TabIndex = 11;
            this.lblRIStatus.Text = "RI";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(49, 139);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 28);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnPortState
            // 
            this.btnPortState.Location = new System.Drawing.Point(49, 192);
            this.btnPortState.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortState.Name = "btnPortState";
            this.btnPortState.Size = new System.Drawing.Size(100, 28);
            this.btnPortState.TabIndex = 13;
            this.btnPortState.Text = "Closed";
            this.btnPortState.UseVisualStyleBackColor = true;
            this.btnPortState.Click += new System.EventHandler(this.btnPortState_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(166, 192);
            this.btnHello.Margin = new System.Windows.Forms.Padding(4);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(100, 28);
            this.btnHello.TabIndex = 14;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // rtbOutgoing
            // 
            this.rtbOutgoing.Location = new System.Drawing.Point(264, 244);
            this.rtbOutgoing.Margin = new System.Windows.Forms.Padding(4);
            this.rtbOutgoing.Name = "rtbOutgoing";
            this.rtbOutgoing.Size = new System.Drawing.Size(213, 117);
            this.rtbOutgoing.TabIndex = 15;
            this.rtbOutgoing.Text = "";
            this.rtbOutgoing.TextChanged += new System.EventHandler(this.rtbOutgoing_TextChanged);
            this.rtbOutgoing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOutgoing_KeyPress);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 627);
            this.splitContainer1.SplitterDistance = 623;
            this.splitContainer1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDatalength);
            this.groupBox1.Controls.Add(this.rtbOutgoing);
            this.groupBox1.Controls.Add(this.lblRIStatus);
            this.groupBox1.Controls.Add(this.rtbIncomingData);
            this.groupBox1.Controls.Add(this.lblDSRStatus);
            this.groupBox1.Controls.Add(this.cboHandShaking);
            this.groupBox1.Controls.Add(this.lblCTSStatus);
            this.groupBox1.Controls.Add(this.cboParity);
            this.groupBox1.Controls.Add(this.lblBreakStatus);
            this.groupBox1.Controls.Add(this.cboStopBits);
            this.groupBox1.Controls.Add(this.cboPorts);
            this.groupBox1.Controls.Add(this.cboBaudRate);
            this.groupBox1.Controls.Add(this.cboDataBits);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 486);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RIG1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data Sets Received from RIG1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Output to Rig1";
            // 
            // lblDatalength
            // 
            this.lblDatalength.AutoSize = true;
            this.lblDatalength.Location = new System.Drawing.Point(12, 215);
            this.lblDatalength.Name = "lblDatalength";
            this.lblDatalength.Size = new System.Drawing.Size(53, 16);
            this.lblDatalength.TabIndex = 17;
            this.lblDatalength.Text = "Counter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblFrequenzPA);
            this.groupBox2.Controls.Add(this.rtbPort3RXBox);
            this.groupBox2.Controls.Add(this.btn2ndHello);
            this.groupBox2.Controls.Add(this.btn2ndPortState);
            this.groupBox2.Controls.Add(this.btn2ndGetSerialPorts);
            this.groupBox2.Controls.Add(this.rtb2ndOutgoing);
            this.groupBox2.Controls.Add(this.rtb2ndIncomingData);
            this.groupBox2.Controls.Add(this.cbo2ndHandShaking);
            this.groupBox2.Controls.Add(this.cbo2ndParity);
            this.groupBox2.Controls.Add(this.cbo2ndStopBits);
            this.groupBox2.Controls.Add(this.cbo2ndPort);
            this.groupBox2.Controls.Add(this.cbo2ndBaudRate);
            this.groupBox2.Controls.Add(this.cbo2ndDataBits);
            this.groupBox2.Location = new System.Drawing.Point(20, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 486);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RIG2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data Sets Received from PA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Output to PA";
            // 
            // lblFrequenzPA
            // 
            this.lblFrequenzPA.AutoSize = true;
            this.lblFrequenzPA.Location = new System.Drawing.Point(164, 406);
            this.lblFrequenzPA.Name = "lblFrequenzPA";
            this.lblFrequenzPA.Size = new System.Drawing.Size(44, 16);
            this.lblFrequenzPA.TabIndex = 23;
            this.lblFrequenzPA.Text = "label1";
            // 
            // rtbPort3RXBox
            // 
            this.rtbPort3RXBox.Location = new System.Drawing.Point(9, 403);
            this.rtbPort3RXBox.Name = "rtbPort3RXBox";
            this.rtbPort3RXBox.Size = new System.Drawing.Size(123, 50);
            this.rtbPort3RXBox.TabIndex = 22;
            this.rtbPort3RXBox.Text = "";
            this.rtbPort3RXBox.TextChanged += new System.EventHandler(this.rtbPort3RXBox_TextChanged);
            // 
            // btn2ndHello
            // 
            this.btn2ndHello.Location = new System.Drawing.Point(136, 145);
            this.btn2ndHello.Margin = new System.Windows.Forms.Padding(4);
            this.btn2ndHello.Name = "btn2ndHello";
            this.btn2ndHello.Size = new System.Drawing.Size(100, 28);
            this.btn2ndHello.TabIndex = 21;
            this.btn2ndHello.Text = "Hello";
            this.btn2ndHello.UseVisualStyleBackColor = true;
            this.btn2ndHello.Click += new System.EventHandler(this.btn2ndHello_Click);
            // 
            // btn2ndPortState
            // 
            this.btn2ndPortState.Location = new System.Drawing.Point(19, 145);
            this.btn2ndPortState.Margin = new System.Windows.Forms.Padding(4);
            this.btn2ndPortState.Name = "btn2ndPortState";
            this.btn2ndPortState.Size = new System.Drawing.Size(100, 28);
            this.btn2ndPortState.TabIndex = 20;
            this.btn2ndPortState.Text = "Closed";
            this.btn2ndPortState.UseVisualStyleBackColor = true;
            this.btn2ndPortState.Click += new System.EventHandler(this.btn2ndPortState_Click);
            // 
            // btn2ndGetSerialPorts
            // 
            this.btn2ndGetSerialPorts.Location = new System.Drawing.Point(19, 52);
            this.btn2ndGetSerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.btn2ndGetSerialPorts.Name = "btn2ndGetSerialPorts";
            this.btn2ndGetSerialPorts.Size = new System.Drawing.Size(100, 28);
            this.btn2ndGetSerialPorts.TabIndex = 18;
            this.btn2ndGetSerialPorts.Text = "Ports";
            this.btn2ndGetSerialPorts.UseVisualStyleBackColor = true;
            this.btn2ndGetSerialPorts.Click += new System.EventHandler(this.btn2ndGetSerialPorts_Click);
            // 
            // rtb2ndOutgoing
            // 
            this.rtb2ndOutgoing.Location = new System.Drawing.Point(264, 244);
            this.rtb2ndOutgoing.Margin = new System.Windows.Forms.Padding(4);
            this.rtb2ndOutgoing.Name = "rtb2ndOutgoing";
            this.rtb2ndOutgoing.Size = new System.Drawing.Size(133, 117);
            this.rtb2ndOutgoing.TabIndex = 15;
            this.rtb2ndOutgoing.Text = "";
            this.rtb2ndOutgoing.TextChanged += new System.EventHandler(this.rtb2ndOutgoing_TextChanged);
            this.rtb2ndOutgoing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb2ndOutgoing_KeyPress);
            // 
            // rtb2ndIncomingData
            // 
            this.rtb2ndIncomingData.Location = new System.Drawing.Point(9, 244);
            this.rtb2ndIncomingData.Margin = new System.Windows.Forms.Padding(4);
            this.rtb2ndIncomingData.Name = "rtb2ndIncomingData";
            this.rtb2ndIncomingData.Size = new System.Drawing.Size(187, 117);
            this.rtb2ndIncomingData.TabIndex = 1;
            this.rtb2ndIncomingData.Text = "";
            // 
            // cbo2ndHandShaking
            // 
            this.cbo2ndHandShaking.FormattingEnabled = true;
            this.cbo2ndHandShaking.Location = new System.Drawing.Point(264, 181);
            this.cbo2ndHandShaking.Margin = new System.Windows.Forms.Padding(4);
            this.cbo2ndHandShaking.Name = "cbo2ndHandShaking";
            this.cbo2ndHandShaking.Size = new System.Drawing.Size(160, 24);
            this.cbo2ndHandShaking.TabIndex = 7;
            // 
            // cbo2ndParity
            // 
            this.cbo2ndParity.FormattingEnabled = true;
            this.cbo2ndParity.Location = new System.Drawing.Point(264, 145);
            this.cbo2ndParity.Margin = new System.Windows.Forms.Padding(4);
            this.cbo2ndParity.Name = "cbo2ndParity";
            this.cbo2ndParity.Size = new System.Drawing.Size(160, 24);
            this.cbo2ndParity.TabIndex = 6;
            // 
            // cbo2ndStopBits
            // 
            this.cbo2ndStopBits.FormattingEnabled = true;
            this.cbo2ndStopBits.Location = new System.Drawing.Point(264, 113);
            this.cbo2ndStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.cbo2ndStopBits.Name = "cbo2ndStopBits";
            this.cbo2ndStopBits.Size = new System.Drawing.Size(160, 24);
            this.cbo2ndStopBits.TabIndex = 5;
            // 
            // cbo2ndPort
            // 
            this.cbo2ndPort.FormattingEnabled = true;
            this.cbo2ndPort.Location = new System.Drawing.Point(264, 11);
            this.cbo2ndPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbo2ndPort.Name = "cbo2ndPort";
            this.cbo2ndPort.Size = new System.Drawing.Size(160, 24);
            this.cbo2ndPort.TabIndex = 2;
            // 
            // cbo2ndBaudRate
            // 
            this.cbo2ndBaudRate.FormattingEnabled = true;
            this.cbo2ndBaudRate.Location = new System.Drawing.Point(264, 52);
            this.cbo2ndBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cbo2ndBaudRate.Name = "cbo2ndBaudRate";
            this.cbo2ndBaudRate.Size = new System.Drawing.Size(160, 24);
            this.cbo2ndBaudRate.TabIndex = 3;
            // 
            // cbo2ndDataBits
            // 
            this.cbo2ndDataBits.FormattingEnabled = true;
            this.cbo2ndDataBits.Location = new System.Drawing.Point(264, 81);
            this.cbo2ndDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.cbo2ndDataBits.Name = "cbo2ndDataBits";
            this.cbo2ndDataBits.Size = new System.Drawing.Size(160, 24);
            this.cbo2ndDataBits.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 124;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 250;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 667);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnPortState);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MultiPort";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.RichTextBox rtbIncomingData;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboHandShaking;
        private System.Windows.Forms.Label lblBreakStatus;
        private System.Windows.Forms.Label lblCTSStatus;
        private System.Windows.Forms.Label lblDSRStatus;
        private System.Windows.Forms.Label lblRIStatus;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnPortState;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.RichTextBox rtbOutgoing;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb2ndOutgoing;
        private System.Windows.Forms.RichTextBox rtb2ndIncomingData;
        private System.Windows.Forms.ComboBox cbo2ndHandShaking;
        private System.Windows.Forms.ComboBox cbo2ndParity;
        private System.Windows.Forms.ComboBox cbo2ndStopBits;
        private System.Windows.Forms.ComboBox cbo2ndPort;
        private System.Windows.Forms.ComboBox cbo2ndBaudRate;
        private System.Windows.Forms.ComboBox cbo2ndDataBits;
        private System.Windows.Forms.Button btn2ndHello;
        private System.Windows.Forms.Button btn2ndPortState;
        private System.Windows.Forms.Button btn2ndGetSerialPorts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtbPort3RXBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblFrequenzPA;
        private System.Windows.Forms.Label lblDatalength;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

