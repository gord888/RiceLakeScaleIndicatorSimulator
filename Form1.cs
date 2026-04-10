using System.IO.Ports;

namespace Simulator
{
    public partial class Form1 : Form
    {
        private SerialPort? _serialPort;
        private readonly System.Windows.Forms.Timer _timer;
        private bool _isRunning;

        public Form1()
        {
            InitializeComponent();

            _timer = new System.Windows.Forms.Timer { Interval = 1000 };
            _timer.Tick += Timer_Tick;

            PopulateDefaults();
        }

        private void PopulateDefaults()
        {
            RefreshComPorts();

            cmbBaudRate.Items.AddRange([300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200]);
            cmbBaudRate.SelectedItem = 9600;

            cmbDataBits.Items.AddRange([7, 8]);
            cmbDataBits.SelectedItem = 8;

            cmbStopBits.Items.AddRange(Enum.GetValues<StopBits>().Cast<object>().ToArray());
            cmbStopBits.SelectedItem = StopBits.One;

            cmbParity.Items.AddRange(Enum.GetValues<Parity>().Cast<object>().ToArray());
            cmbParity.SelectedItem = Parity.None;

            rbLb.Checked = true;
        }

        private void RefreshComPorts()
        {
            string? previous = cmbComPort.SelectedItem?.ToString();
            cmbComPort.Items.Clear();
            cmbComPort.Items.AddRange(SerialPort.GetPortNames());

            if (previous != null && cmbComPort.Items.Contains(previous))
                cmbComPort.SelectedItem = previous;
            else if (cmbComPort.Items.Count > 0)
                cmbComPort.SelectedIndex = 0;
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e) => RefreshComPorts();

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
                StopSimulation();
            else
                StartSimulation();
        }

        private void StartSimulation()
        {
            if (cmbComPort.SelectedItem == null)
            {
                MessageBox.Show("Please select a COM port.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _serialPort = new SerialPort
                {
                    PortName = cmbComPort.SelectedItem.ToString()!,
                    BaudRate = (int)cmbBaudRate.SelectedItem!,
                    DataBits = (int)cmbDataBits.SelectedItem!,
                    StopBits = (StopBits)cmbStopBits.SelectedItem!,
                    Parity = (Parity)cmbParity.SelectedItem!
                };
                _serialPort.Open();

                _timer.Start();
                _isRunning = true;
                btnStartStop.Text = "Stop";
                lblStatus.Text = "Running";
                lblStatus.ForeColor = Color.Green;
                SetControlsEnabled(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening port: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _serialPort?.Dispose();
                _serialPort = null;
            }
        }

        private void StopSimulation()
        {
            _timer.Stop();
            _serialPort?.Close();
            _serialPort?.Dispose();
            _serialPort = null;
            _isRunning = false;
            btnStartStop.Text = "Start";
            lblStatus.Text = "Stopped";
            lblStatus.ForeColor = Color.Red;
            SetControlsEnabled(true);
        }

        private void SetControlsEnabled(bool enabled)
        {
            cmbComPort.Enabled = enabled;
            btnRefreshPorts.Enabled = enabled;
            cmbBaudRate.Enabled = enabled;
            cmbDataBits.Enabled = enabled;
            cmbStopBits.Enabled = enabled;
            cmbParity.Enabled = enabled;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (_serialPort == null || !_serialPort.IsOpen)
                return;

            try
            {
                string output = BuildCsl680Output();
                _serialPort.Write(output);

                txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {EscapeForDisplay(output)}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] ERROR: {ex.Message}{Environment.NewLine}");
                StopSimulation();
            }
        }

        /// <summary>
        /// Builds a Rice Lake CSL680 continuous output string.
        /// Format: STX + status + polarity + weight(7 chars, right-justified) + space + unit(2) + CR + LF
        /// Example: \x02   125.00 lb\r\n
        /// </summary>
        private string BuildCsl680Output()
        {
            decimal weight = nudWeight.Value;
            string unit = rbKg.Checked ? "kg" : "lb";

            const char stx = '\x02';
            char status = ' ';   // space = stable / no motion
            char polarity = weight >= 0 ? ' ' : '-';
            string weightStr = Math.Abs(weight).ToString("F2").PadLeft(7);

            return $"{stx}{status}{polarity}{weightStr} {unit}\r\n";
        }

        private static string EscapeForDisplay(string s)
        {
            return s.Replace("\x02", "<STX>")
                    .Replace("\r", "<CR>")
                    .Replace("\n", "<LF>");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_isRunning)
                StopSimulation();
            base.OnFormClosing(e);
        }
    }
}
