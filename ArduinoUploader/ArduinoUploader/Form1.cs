using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ArduinoUploader
{
    public partial class Form1 : Form
    {
        private string avrdudePath = @"C:\Users\Charles\AppData\Local\Arduino15\packages\arduino\tools\avrdude\6.3.0-arduino17\bin\avrdude.exe"; // **Important:** Set this to the actual path!
        private string avrdudeConfPath = @"C:\Users\Charles\AppData\Local\Arduino15\packages\arduino\tools\avrdude\6.3.0-arduino17\etc\avrdude.conf"; // **Important:** Set this!
        private Dictionary<string, string> boardMappings = new Dictionary<string, string>(); // Board to avrdude settings
        private const int DEFAULT_BAUD_RATE = 115200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSoftwareVersion();
            InitializeBoardMappings();
            PopulateSerialPorts();
            PopulateBaudRates();
        }

        private void LoadSoftwareVersion()
        {
            // Get the assembly version
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            // Set the Form Title to include the version
            this.Text = $"Arduino Uploader - v{version}";
        }

        private void InitializeBoardMappings()
        {
            // **Important:** These are example mappings.  You *must* adjust them
            //              to match the avrdude configuration for your setup!
            //              This is where you'd use data from platform.txt or equivalent.
            boardMappings.Add("Arduino Uno", "-pm328p -carduino -b115200 -D"); // Example: Uno
            boardMappings.Add("Arduino Nano", "-pm328p -carduino -b57600 -D"); // Example: Nano
            boardMappings.Add("Arduino Mega 2560", "-pm2560 -carduino -b115200 -D"); // Example: Mega
            // Add more boards as needed.  The parameters are:
            // -p <processor>  (e.g., m328p, m2560)
            // -c <programmer> (e.g., arduino, avrisp)
            // -b <baudrate>
            // -D (disable auto-erase for flash)
            cmbBoard.Items.AddRange(boardMappings.Keys.ToArray());
            if (cmbBoard.Items.Count > 0)
                cmbBoard.SelectedIndex = 0; // Select the first board by default
        }

        private void PopulateSerialPorts()
        {
            cmbPort.Items.Clear();
            try
            {
                string[] ports = SerialPort.GetPortNames();
                cmbPort.Items.AddRange(ports);
                if (ports.Length > 0)
                    cmbPort.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                txtOutput.AppendText("Error enumerating serial ports: " + ex.Message + Environment.NewLine);
            }
        }

        private void PopulateBaudRates()
        {
            cmbBaudRate.Items.Add(9600);
            cmbBaudRate.Items.Add(57600);
            cmbBaudRate.Items.Add(115200);
            cmbBaudRate.SelectedItem = DEFAULT_BAUD_RATE;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arduino Sketch (*.ino)|*.ino|HEX Files (*.hex)|*.hex|All Files (*.*)|*.*";
            openFileDialog.Title = "Open Arduino Sketch or HEX File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("Please select a sketch or HEX file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cmbPort.Text))
            {
                MessageBox.Show("Please select a serial port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(avrdudePath))
            {
                MessageBox.Show($"avrdude.exe not found at: {avrdudePath}\nPlease configure the path in the code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(avrdudeConfPath))
            {
                MessageBox.Show($"avrdude.conf not found at: {avrdudeConfPath}\nPlease configure the path in the code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  Check if the selected board is Arduino Due (You will need a combobox for board type)
            if (cmbBoard.SelectedItem.ToString() == "Arduino Due")
            {
                
            }
            else
            {
                //  Handle other Arduino boards (AVR) as before, or ideally with Avrdude
                UploadSketchAvr(); // Hypothetical method
            }
        }

        private void UploadSketchAvr()
        {
            string hexFile;
            if (txtFilePath.Text.ToLower().EndsWith(".ino"))
            {
                //  Simplified compilation.  In reality, you'd need the full Arduino build process.
                //  For this example, we'll assume the user has already compiled it manually.
                txtOutput.AppendText("Assuming sketch is already compiled.  Using .ino as .hex (for demonstration only!)..." + Environment.NewLine);
                hexFile = txtFilePath.Text.Replace(".ino", ".hex"); // For demonstration only!
                if (!File.Exists(hexFile))
                {
                    MessageBox.Show("Please compile the .ino sketch first.  A .hex file with the same name is expected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                hexFile = txtFilePath.Text;
            }
            if (!boardMappings.ContainsKey(cmbBoard.Text))
            {
                MessageBox.Show($"Board type '{cmbBoard.Text}' is not configured in the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string avrdudeArgs = boardMappings[cmbBoard.Text] +
                                  $" -P{cmbPort.Text} " + // Port
                                  $" -Uflash:w:\"{hexFile}\":i"; // Write flash, Intel hex format

            txtOutput.Clear();
            txtOutput.AppendText("Uploading..." + Environment.NewLine);
            txtOutput.AppendText($"avrdude command: {avrdudePath} {avrdudeArgs}" + Environment.NewLine);

            Process process = new Process();
            process.StartInfo.FileName = avrdudePath;
            process.StartInfo.Arguments = avrdudeArgs;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true; // Hide the command window
            process.StartInfo.WorkingDirectory = Path.GetDirectoryName(avrdudePath); // Ensure avrdude finds avrdude.conf

            process.OutputDataReceived += (sender, e) =>
            {
                if (e.Data != null)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        txtOutput.AppendText(e.Data + Environment.NewLine);
                        //  Basic progress parsing (very rudimentary - avrdude's output can vary)
                        if (e.Data.Contains("%"))
                        {
                            try
                            {
                                string progressStr = e.Data.Substring(e.Data.IndexOf('(') + 1, e.Data.IndexOf(')') - e.Data.IndexOf('(') - 1).Replace("%", "").Trim();
                                int progress = int.Parse(progressStr);
                                progressBar.Value = progress;
                            }
                            catch { /* Ignore parsing errors */ }
                        }
                    });
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (e.Data != null)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        txtOutput.AppendText("Error: " + e.Data + Environment.NewLine);
                    });
                }
            };
            process.EnableRaisingEvents = true; // Needed for Exited event
            process.Start();
            process.BeginOutputReadLine(); // Start async reading of output
            process.BeginErrorReadLine();  // Start async reading of error

            // Handle process exit
            process.Exited += (sender, e) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    if (process.ExitCode == 0)
                    {
                        txtOutput.AppendText("Upload successful!" + Environment.NewLine);
                        progressBar.Value = 100;
                    }
                    else
                    {
                        txtOutput.AppendText("Upload failed.  Exit code: " + process.ExitCode + Environment.NewLine);
                    }
                    EnableControls(true); // Re-enable buttons
                });
            };

            EnableControls(false); // Disable buttons during upload
        }

        private void EnableControls(bool enable)
        {
            btnBrowse.Enabled = enable;
            btnUpload.Enabled = enable;
            cmbBoard.Enabled = enable;
            cmbPort.Enabled = enable;
            cmbBaudRate.Enabled = enable;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbPort.Items.Clear();
            PopulateSerialPorts();
        }
    }
}
