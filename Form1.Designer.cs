namespace Simulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpSerialPort = new GroupBox();
            lblComPort = new Label();
            cmbComPort = new ComboBox();
            btnRefreshPorts = new Button();
            lblBaudRate = new Label();
            cmbBaudRate = new ComboBox();
            lblDataBits = new Label();
            cmbDataBits = new ComboBox();
            lblStopBits = new Label();
            cmbStopBits = new ComboBox();
            lblParity = new Label();
            cmbParity = new ComboBox();
            grpScaleOutput = new GroupBox();
            lblWeight = new Label();
            nudWeight = new NumericUpDown();
            rbLb = new RadioButton();
            rbKg = new RadioButton();
            btnStartStop = new Button();
            lblStatus = new Label();
            lblLog = new Label();
            txtLog = new TextBox();
            grpSerialPort.SuspendLayout();
            grpScaleOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            SuspendLayout();
            //
            // grpSerialPort
            //
            grpSerialPort.Controls.Add(lblComPort);
            grpSerialPort.Controls.Add(cmbComPort);
            grpSerialPort.Controls.Add(btnRefreshPorts);
            grpSerialPort.Controls.Add(lblBaudRate);
            grpSerialPort.Controls.Add(cmbBaudRate);
            grpSerialPort.Controls.Add(lblDataBits);
            grpSerialPort.Controls.Add(cmbDataBits);
            grpSerialPort.Controls.Add(lblStopBits);
            grpSerialPort.Controls.Add(cmbStopBits);
            grpSerialPort.Controls.Add(lblParity);
            grpSerialPort.Controls.Add(cmbParity);
            grpSerialPort.Location = new Point(12, 12);
            grpSerialPort.Name = "grpSerialPort";
            grpSerialPort.Size = new Size(240, 200);
            grpSerialPort.TabIndex = 0;
            grpSerialPort.TabStop = false;
            grpSerialPort.Text = "Serial Port Settings";
            //
            // lblComPort
            //
            lblComPort.AutoSize = true;
            lblComPort.Location = new Point(10, 28);
            lblComPort.Name = "lblComPort";
            lblComPort.Size = new Size(63, 15);
            lblComPort.Text = "COM Port:";
            //
            // cmbComPort
            //
            cmbComPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComPort.Location = new Point(90, 25);
            cmbComPort.Name = "cmbComPort";
            cmbComPort.Size = new Size(100, 23);
            //
            // btnRefreshPorts
            //
            btnRefreshPorts.Location = new Point(196, 24);
            btnRefreshPorts.Name = "btnRefreshPorts";
            btnRefreshPorts.Size = new Size(35, 25);
            btnRefreshPorts.Text = "↻";
            btnRefreshPorts.UseVisualStyleBackColor = true;
            btnRefreshPorts.Click += btnRefreshPorts_Click;
            //
            // lblBaudRate
            //
            lblBaudRate.AutoSize = true;
            lblBaudRate.Location = new Point(10, 61);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(63, 15);
            lblBaudRate.Text = "Baud Rate:";
            //
            // cmbBaudRate
            //
            cmbBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBaudRate.Location = new Point(90, 58);
            cmbBaudRate.Name = "cmbBaudRate";
            cmbBaudRate.Size = new Size(100, 23);
            //
            // lblDataBits
            //
            lblDataBits.AutoSize = true;
            lblDataBits.Location = new Point(10, 94);
            lblDataBits.Name = "lblDataBits";
            lblDataBits.Size = new Size(58, 15);
            lblDataBits.Text = "Data Bits:";
            //
            // cmbDataBits
            //
            cmbDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDataBits.Location = new Point(90, 91);
            cmbDataBits.Name = "cmbDataBits";
            cmbDataBits.Size = new Size(100, 23);
            //
            // lblStopBits
            //
            lblStopBits.AutoSize = true;
            lblStopBits.Location = new Point(10, 127);
            lblStopBits.Name = "lblStopBits";
            lblStopBits.Size = new Size(58, 15);
            lblStopBits.Text = "Stop Bits:";
            //
            // cmbStopBits
            //
            cmbStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStopBits.Location = new Point(90, 124);
            cmbStopBits.Name = "cmbStopBits";
            cmbStopBits.Size = new Size(100, 23);
            //
            // lblParity
            //
            lblParity.AutoSize = true;
            lblParity.Location = new Point(10, 160);
            lblParity.Name = "lblParity";
            lblParity.Size = new Size(41, 15);
            lblParity.Text = "Parity:";
            //
            // cmbParity
            //
            cmbParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParity.Location = new Point(90, 157);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(100, 23);
            //
            // grpScaleOutput
            //
            grpScaleOutput.Controls.Add(lblWeight);
            grpScaleOutput.Controls.Add(nudWeight);
            grpScaleOutput.Controls.Add(rbLb);
            grpScaleOutput.Controls.Add(rbKg);
            grpScaleOutput.Location = new Point(264, 12);
            grpScaleOutput.Name = "grpScaleOutput";
            grpScaleOutput.Size = new Size(240, 130);
            grpScaleOutput.TabIndex = 1;
            grpScaleOutput.TabStop = false;
            grpScaleOutput.Text = "Scale Output";
            //
            // lblWeight
            //
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(10, 28);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(48, 15);
            lblWeight.Text = "Weight:";
            //
            // nudWeight
            //
            nudWeight.DecimalPlaces = 2;
            nudWeight.Location = new Point(70, 25);
            nudWeight.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudWeight.Minimum = new decimal(new int[] { 999999, 0, 0, unchecked((int)0x80000000) });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(150, 23);
            //
            // rbLb
            //
            rbLb.AutoSize = true;
            rbLb.Location = new Point(70, 58);
            rbLb.Name = "rbLb";
            rbLb.Size = new Size(36, 19);
            rbLb.Text = "lb";
            rbLb.UseVisualStyleBackColor = true;
            //
            // rbKg
            //
            rbKg.AutoSize = true;
            rbKg.Location = new Point(70, 88);
            rbKg.Name = "rbKg";
            rbKg.Size = new Size(38, 19);
            rbKg.Text = "kg";
            rbKg.UseVisualStyleBackColor = true;
            //
            // btnStartStop
            //
            btnStartStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStartStop.Location = new Point(12, 225);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(120, 35);
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(145, 233);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 15);
            lblStatus.Text = "Stopped";
            //
            // lblLog
            //
            lblLog.AutoSize = true;
            lblLog.Location = new Point(12, 272);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(72, 15);
            lblLog.Text = "Output Log:";
            //
            // txtLog
            //
            txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLog.Font = new Font("Consolas", 9F);
            txtLog.Location = new Point(12, 292);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(492, 220);
            //
            // Form1
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 525);
            Controls.Add(grpSerialPort);
            Controls.Add(grpScaleOutput);
            Controls.Add(btnStartStop);
            Controls.Add(lblStatus);
            Controls.Add(lblLog);
            Controls.Add(txtLog);
            MinimumSize = new Size(536, 564);
            Name = "Form1";
            Text = "Rice Lake CSL680 Simulator";
            grpSerialPort.ResumeLayout(false);
            grpSerialPort.PerformLayout();
            grpScaleOutput.ResumeLayout(false);
            grpScaleOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSerialPort;
        private Label lblComPort;
        private ComboBox cmbComPort;
        private Button btnRefreshPorts;
        private Label lblBaudRate;
        private ComboBox cmbBaudRate;
        private Label lblDataBits;
        private ComboBox cmbDataBits;
        private Label lblStopBits;
        private ComboBox cmbStopBits;
        private Label lblParity;
        private ComboBox cmbParity;
        private GroupBox grpScaleOutput;
        private Label lblWeight;
        private NumericUpDown nudWeight;
        private RadioButton rbLb;
        private RadioButton rbKg;
        private Button btnStartStop;
        private Label lblStatus;
        private Label lblLog;
        private TextBox txtLog;
    }
}
