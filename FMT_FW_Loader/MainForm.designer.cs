namespace FMT_FW_Loader
{
    partial class MainForm
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
            System.Windows.Forms.Label baudRateLabel;
            System.Windows.Forms.Label portNameLabel;
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnRefreshSerialPorts = new System.Windows.Forms.Button();
            this.btnLoadFW = new System.Windows.Forms.Button();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.btnCWD = new System.Windows.Forms.Button();
            this.btnFW = new System.Windows.Forms.Button();
            this.btnPartitions = new System.Windows.Forms.Button();
            this.btnBoot_App0 = new System.Windows.Forms.Button();
            this.btnBootloader = new System.Windows.Forms.Button();
            this.txtLookup = new System.Windows.Forms.TextBox();
            this.txtBootloader = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.txtBootApp0 = new System.Windows.Forms.TextBox();
            this.txtTestStandID = new System.Windows.Forms.TextBox();
            this.txtPartitions = new System.Windows.Forms.TextBox();
            this.lblTestStandID = new System.Windows.Forms.Label();
            this.txtFW = new System.Windows.Forms.TextBox();
            this.txtCWD = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            baudRateLabel = new System.Windows.Forms.Label();
            portNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new System.Drawing.Point(206, 89);
            baudRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new System.Drawing.Size(75, 17);
            baudRateLabel.TabIndex = 1;
            baudRateLabel.Text = "Baud Rate";
            // 
            // portNameLabel
            // 
            portNameLabel.AutoSize = true;
            portNameLabel.Location = new System.Drawing.Point(206, 65);
            portNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            portNameLabel.Name = "portNameLabel";
            portNameLabel.Size = new System.Drawing.Size(75, 17);
            portNameLabel.TabIndex = 7;
            portNameLabel.Text = "Port Name";
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(286, 64);
            this.portNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(114, 24);
            this.portNameComboBox.TabIndex = 4;
            this.portNameComboBox.SelectedIndexChanged += new System.EventHandler(this.portNameComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnRefreshSerialPorts);
            this.groupBox1.Controls.Add(this.btnLoadFW);
            this.groupBox1.Controls.Add(this.portNameComboBox);
            this.groupBox1.Controls.Add(this.txtBaudRate);
            this.groupBox1.Controls.Add(portNameLabel);
            this.groupBox1.Controls.Add(this.txtDeviceID);
            this.groupBox1.Controls.Add(baudRateLabel);
            this.groupBox1.Controls.Add(this.lblDeviceID);
            this.groupBox1.Location = new System.Drawing.Point(31, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(453, 268);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "V1.0";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(204, 210);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(193, 23);
            this.progressBar1.Step = 45;
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnRefreshSerialPorts
            // 
            this.btnRefreshSerialPorts.Location = new System.Drawing.Point(204, 122);
            this.btnRefreshSerialPorts.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshSerialPorts.Name = "btnRefreshSerialPorts";
            this.btnRefreshSerialPorts.Size = new System.Drawing.Size(193, 40);
            this.btnRefreshSerialPorts.TabIndex = 23;
            this.btnRefreshSerialPorts.Text = "Refresh Serial Ports";
            this.btnRefreshSerialPorts.UseVisualStyleBackColor = true;
            this.btnRefreshSerialPorts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadFW
            // 
            this.btnLoadFW.Location = new System.Drawing.Point(253, 166);
            this.btnLoadFW.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFW.Name = "btnLoadFW";
            this.btnLoadFW.Size = new System.Drawing.Size(102, 39);
            this.btnLoadFW.TabIndex = 5;
            this.btnLoadFW.Text = "Load FW";
            this.btnLoadFW.UseVisualStyleBackColor = true;
            this.btnLoadFW.Click += new System.EventHandler(this.buttonLoadFW_Click);
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(286, 89);
            this.txtBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(114, 22);
            this.txtBaudRate.TabIndex = 11;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(286, 39);
            this.txtDeviceID.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(114, 22);
            this.txtDeviceID.TabIndex = 3;
            this.txtDeviceID.TextChanged += new System.EventHandler(this.txtDeviceID_TextChanged);
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Location = new System.Drawing.Point(208, 41);
            this.lblDeviceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(68, 17);
            this.lblDeviceID.TabIndex = 3;
            this.lblDeviceID.Text = "Device ID\r\n";
            this.lblDeviceID.Click += new System.EventHandler(this.lblDeviceID_Click);
            // 
            // btnCWD
            // 
            this.btnCWD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCWD.Location = new System.Drawing.Point(856, 46);
            this.btnCWD.Margin = new System.Windows.Forms.Padding(4);
            this.btnCWD.Name = "btnCWD";
            this.btnCWD.Size = new System.Drawing.Size(100, 28);
            this.btnCWD.TabIndex = 28;
            this.btnCWD.Text = "Working Dir";
            this.btnCWD.UseVisualStyleBackColor = true;
            this.btnCWD.Click += new System.EventHandler(this.btnCWD_Click);
            // 
            // btnFW
            // 
            this.btnFW.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFW.Location = new System.Drawing.Point(856, 84);
            this.btnFW.Margin = new System.Windows.Forms.Padding(4);
            this.btnFW.Name = "btnFW";
            this.btnFW.Size = new System.Drawing.Size(100, 28);
            this.btnFW.TabIndex = 27;
            this.btnFW.Text = "Firmware";
            this.btnFW.UseVisualStyleBackColor = true;
            // 
            // btnPartitions
            // 
            this.btnPartitions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPartitions.Location = new System.Drawing.Point(856, 121);
            this.btnPartitions.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartitions.Name = "btnPartitions";
            this.btnPartitions.Size = new System.Drawing.Size(100, 28);
            this.btnPartitions.TabIndex = 26;
            this.btnPartitions.Text = "Partitions";
            this.btnPartitions.UseVisualStyleBackColor = true;
            // 
            // btnBoot_App0
            // 
            this.btnBoot_App0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoot_App0.Location = new System.Drawing.Point(856, 158);
            this.btnBoot_App0.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoot_App0.Name = "btnBoot_App0";
            this.btnBoot_App0.Size = new System.Drawing.Size(100, 28);
            this.btnBoot_App0.TabIndex = 25;
            this.btnBoot_App0.Text = "Boot_App0";
            this.btnBoot_App0.UseVisualStyleBackColor = true;
            // 
            // btnBootloader
            // 
            this.btnBootloader.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBootloader.Location = new System.Drawing.Point(856, 195);
            this.btnBootloader.Margin = new System.Windows.Forms.Padding(4);
            this.btnBootloader.Name = "btnBootloader";
            this.btnBootloader.Size = new System.Drawing.Size(100, 28);
            this.btnBootloader.TabIndex = 24;
            this.btnBootloader.Text = "Boot Loader";
            this.btnBootloader.UseVisualStyleBackColor = true;
            // 
            // txtLookup
            // 
            this.txtLookup.Enabled = false;
            this.txtLookup.Location = new System.Drawing.Point(962, 237);
            this.txtLookup.Margin = new System.Windows.Forms.Padding(2);
            this.txtLookup.Name = "txtLookup";
            this.txtLookup.Size = new System.Drawing.Size(276, 22);
            this.txtLookup.TabIndex = 13;
            // 
            // txtBootloader
            // 
            this.txtBootloader.Enabled = false;
            this.txtBootloader.Location = new System.Drawing.Point(962, 199);
            this.txtBootloader.Margin = new System.Windows.Forms.Padding(2);
            this.txtBootloader.Name = "txtBootloader";
            this.txtBootloader.Size = new System.Drawing.Size(276, 22);
            this.txtBootloader.TabIndex = 17;
            // 
            // btnLookup
            // 
            this.btnLookup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLookup.Location = new System.Drawing.Point(856, 232);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(4);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(100, 28);
            this.btnLookup.TabIndex = 12;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtBootApp0
            // 
            this.txtBootApp0.Enabled = false;
            this.txtBootApp0.Location = new System.Drawing.Point(962, 161);
            this.txtBootApp0.Margin = new System.Windows.Forms.Padding(2);
            this.txtBootApp0.Name = "txtBootApp0";
            this.txtBootApp0.Size = new System.Drawing.Size(276, 22);
            this.txtBootApp0.TabIndex = 20;
            // 
            // txtTestStandID
            // 
            this.txtTestStandID.Location = new System.Drawing.Point(687, 237);
            this.txtTestStandID.Margin = new System.Windows.Forms.Padding(2);
            this.txtTestStandID.Name = "txtTestStandID";
            this.txtTestStandID.Size = new System.Drawing.Size(114, 22);
            this.txtTestStandID.TabIndex = 2;
            // 
            // txtPartitions
            // 
            this.txtPartitions.Enabled = false;
            this.txtPartitions.Location = new System.Drawing.Point(962, 123);
            this.txtPartitions.Margin = new System.Windows.Forms.Padding(2);
            this.txtPartitions.Name = "txtPartitions";
            this.txtPartitions.Size = new System.Drawing.Size(276, 22);
            this.txtPartitions.TabIndex = 16;
            // 
            // lblTestStandID
            // 
            this.lblTestStandID.AutoSize = true;
            this.lblTestStandID.Location = new System.Drawing.Point(589, 240);
            this.lblTestStandID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestStandID.Name = "lblTestStandID";
            this.lblTestStandID.Size = new System.Drawing.Size(94, 17);
            this.lblTestStandID.TabIndex = 6;
            this.lblTestStandID.Text = "Test Stand ID";
            // 
            // txtFW
            // 
            this.txtFW.Enabled = false;
            this.txtFW.Location = new System.Drawing.Point(962, 85);
            this.txtFW.Margin = new System.Windows.Forms.Padding(2);
            this.txtFW.Name = "txtFW";
            this.txtFW.Size = new System.Drawing.Size(276, 22);
            this.txtFW.TabIndex = 12;
            // 
            // txtCWD
            // 
            this.txtCWD.Enabled = false;
            this.txtCWD.Location = new System.Drawing.Point(962, 46);
            this.txtCWD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCWD.Name = "txtCWD";
            this.txtCWD.Size = new System.Drawing.Size(276, 22);
            this.txtCWD.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(637, 217);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(687, 213);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 22);
            this.txtName.TabIndex = 1;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(2, 17);
            this.tbData.Margin = new System.Windows.Forms.Padding(4);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(646, 191);
            this.tbData.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCWD);
            this.groupBox4.Controls.Add(this.btnFW);
            this.groupBox4.Controls.Add(this.txtTestStandID);
            this.groupBox4.Controls.Add(this.tbData);
            this.groupBox4.Controls.Add(this.btnPartitions);
            this.groupBox4.Controls.Add(this.lblTestStandID);
            this.groupBox4.Controls.Add(this.txtCWD);
            this.groupBox4.Controls.Add(this.btnBoot_App0);
            this.groupBox4.Controls.Add(this.txtFW);
            this.groupBox4.Controls.Add(this.btnBootloader);
            this.groupBox4.Controls.Add(this.txtPartitions);
            this.groupBox4.Controls.Add(this.lblName);
            this.groupBox4.Controls.Add(this.txtLookup);
            this.groupBox4.Controls.Add(this.txtBootApp0);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.txtBootloader);
            this.groupBox4.Controls.Add(this.btnLookup);
            this.groupBox4.Location = new System.Drawing.Point(29, 290);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(1286, 343);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progress Monitor";
            this.groupBox4.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnLoadFW;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnLookup;
            this.ClientSize = new System.Drawing.Size(1299, 621);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 3, 8, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "FMT FWL";
            this.Text = "FMT FW Loader";
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnLoadFW;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.TextBox txtCWD;
        private System.Windows.Forms.TextBox txtLookup;
        private System.Windows.Forms.TextBox txtFW;
        private System.Windows.Forms.Button btnRefreshSerialPorts;
        private System.Windows.Forms.TextBox txtTestStandID;
        private System.Windows.Forms.Label lblTestStandID;
        private System.Windows.Forms.TextBox txtPartitions;
        private System.Windows.Forms.TextBox txtBootloader;
        private System.Windows.Forms.TextBox txtBootApp0;
        private System.Windows.Forms.Button btnFW;
        private System.Windows.Forms.Button btnPartitions;
        private System.Windows.Forms.Button btnBoot_App0;
        private System.Windows.Forms.Button btnBootloader;
        private System.Windows.Forms.Button btnCWD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

