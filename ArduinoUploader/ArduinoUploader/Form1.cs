using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Reflection;
using System.Windows.Forms;

namespace ArduinoUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAvailablePorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSoftwareVersion();
        }

        private void LoadSoftwareVersion()
        {
            // Get the assembly version
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            // Set the Form Title to include the version
            this.Text = $"Arduino Uploader - v{version}";
        }

        private void LoadAvailablePorts()
        {
            cmbPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Binary files (*.bin)|*.bin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string port = cmbPort.SelectedItem?.ToString();
            string filePath = txtFilePath.Text;

            if (string.IsNullOrEmpty(port) || string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please select a port and a binary file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Trigger the bootloader before uploading
            TriggerBootloader(port);

            // Proceed with the firmware upload
            UploadFirmware(port, filePath);
        }

        private void TriggerBootloader(string port)
        {
            try
            {
                txtLog.AppendText($"Triggering bootloader on {port}...\r\n");
                using (SerialPort serialPort = new SerialPort(port, 1200))
                {
                    serialPort.Open();
                    System.Threading.Thread.Sleep(1000); // Delay for activation
                    serialPort.Close();
                }
                txtLog.AppendText("Bootloader mode activated.\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error triggering bootloader: {ex.Message}", "Bootloader Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                txtLog.AppendText($"Bootloader activation failed: {ex.Message}\r\n");
            }
        }

        private void UploadFirmware(string port, string filePath)
        {
            txtLog.AppendText("Starting upload...\r\n");
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c bossac.exe -i -d --port\"{port}\" -U false -e -w -v -b \"{filePath}\" -R --force",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.OutputDataReceived += (sender, args) => txtLog.Invoke((MethodInvoker)(() => txtLog.AppendText(args.Data 
                    + "\r\n")));
                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();
            }

            txtLog.AppendText("Upload complete!\r\n");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAvailablePorts();
        }

    }
}
