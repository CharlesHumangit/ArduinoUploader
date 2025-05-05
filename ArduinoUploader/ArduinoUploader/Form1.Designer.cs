namespace ArduinoUploader
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
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.cmbBoard = new System.Windows.Forms.ComboBox();
            this.lblBoad = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPort
            // 
            this.cmbPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPort.BackColor = System.Drawing.Color.LightYellow;
            this.cmbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(481, 31);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(143, 39);
            this.cmbPort.TabIndex = 0;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.BackColor = System.Drawing.Color.LightYellow;
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(112, 94);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(765, 38);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(883, 88);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(119, 52);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(3, 146);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(1002, 50);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.LightYellow;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Location = new System.Drawing.Point(0, 227);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1008, 502);
            this.txtOutput.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.lblBaudRate);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.cmbBoard);
            this.groupBox1.Controls.Add(this.lblBoad);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(28, 97);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(78, 31);
            this.lblPath.TabIndex = 7;
            this.lblPath.Text = "Path:";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBaudRate.BackColor = System.Drawing.Color.LightYellow;
            this.cmbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(833, 31);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(163, 39);
            this.cmbBaudRate.TabIndex = 0;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(677, 34);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(150, 31);
            this.lblBaudRate.TabIndex = 6;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // lblPort
            // 
            this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(403, 34);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(72, 31);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port:";
            // 
            // cmbBoard
            // 
            this.cmbBoard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoard.BackColor = System.Drawing.Color.LightYellow;
            this.cmbBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoard.FormattingEnabled = true;
            this.cmbBoard.Location = new System.Drawing.Point(112, 31);
            this.cmbBoard.Name = "cmbBoard";
            this.cmbBoard.Size = new System.Drawing.Size(278, 39);
            this.cmbBoard.TabIndex = 0;
            // 
            // lblBoad
            // 
            this.lblBoad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBoad.AutoSize = true;
            this.lblBoad.Location = new System.Drawing.Point(12, 34);
            this.lblBoad.Name = "lblBoad";
            this.lblBoad.Size = new System.Drawing.Size(94, 31);
            this.lblBoad.TabIndex = 4;
            this.lblBoad.Text = "Board:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(630, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(0, 199);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1008, 30);
            this.progressBar.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Arduino Uploader - v1.0.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbBoard;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblBoad;
    }
}

