namespace SerialPortListener
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
            this.btnCWD = new System.Windows.Forms.Button();
            this.btnFW = new System.Windows.Forms.Button();
            this.btnPartitions = new System.Windows.Forms.Button();
            this.btnBoot_App0 = new System.Windows.Forms.Button();
            this.btnBootloader = new System.Windows.Forms.Button();
            this.txtLookup = new System.Windows.Forms.TextBox();
            this.txtBootloader = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnRefreshSerialPorts = new System.Windows.Forms.Button();
            this.txtBootApp0 = new System.Windows.Forms.TextBox();
            this.btnLoadFW = new System.Windows.Forms.Button();
            this.txtTestStandID = new System.Windows.Forms.TextBox();
            this.txtPartitions = new System.Windows.Forms.TextBox();
            this.lblTestStandID = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtFW = new System.Windows.Forms.TextBox();
            this.txtCWD = new System.Windows.Forms.TextBox();
            this.txtBoardSN = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBoardSN = new System.Windows.Forms.Label();
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
            baudRateLabel.Location = new System.Drawing.Point(32, 229);
            baudRateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new System.Drawing.Size(149, 32);
            baudRateLabel.TabIndex = 1;
            baudRateLabel.Text = "Baud Rate";
            // 
            // portNameLabel
            // 
            portNameLabel.AutoSize = true;
            portNameLabel.Location = new System.Drawing.Point(32, 182);
            portNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            portNameLabel.Name = "portNameLabel";
            portNameLabel.Size = new System.Drawing.Size(149, 32);
            portNameLabel.TabIndex = 7;
            portNameLabel.Text = "Port Name";
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(192, 180);
            this.portNameComboBox.Margin = new System.Windows.Forms.Padding(8);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(224, 39);
            this.portNameComboBox.TabIndex = 4;
            this.portNameComboBox.SelectedIndexChanged += new System.EventHandler(this.portNameComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCWD);
            this.groupBox1.Controls.Add(this.btnFW);
            this.groupBox1.Controls.Add(this.btnPartitions);
            this.groupBox1.Controls.Add(this.btnBoot_App0);
            this.groupBox1.Controls.Add(this.btnBootloader);
            this.groupBox1.Controls.Add(this.txtLookup);
            this.groupBox1.Controls.Add(this.txtBootloader);
            this.groupBox1.Controls.Add(this.btnLookup);
            this.groupBox1.Controls.Add(this.btnRefreshSerialPorts);
            this.groupBox1.Controls.Add(this.txtBootApp0);
            this.groupBox1.Controls.Add(this.btnLoadFW);
            this.groupBox1.Controls.Add(this.txtTestStandID);
            this.groupBox1.Controls.Add(this.portNameComboBox);
            this.groupBox1.Controls.Add(this.txtPartitions);
            this.groupBox1.Controls.Add(this.lblTestStandID);
            this.groupBox1.Controls.Add(this.txtBaudRate);
            this.groupBox1.Controls.Add(this.txtFW);
            this.groupBox1.Controls.Add(this.txtCWD);
            this.groupBox1.Controls.Add(portNameLabel);
            this.groupBox1.Controls.Add(this.txtBoardSN);
            this.groupBox1.Controls.Add(baudRateLabel);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblBoardSN);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(58, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(1309, 520);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // btnCWD
            // 
            this.btnCWD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCWD.Location = new System.Drawing.Point(510, 59);
            this.btnCWD.Margin = new System.Windows.Forms.Padding(8);
            this.btnCWD.Name = "btnCWD";
            this.btnCWD.Size = new System.Drawing.Size(200, 54);
            this.btnCWD.TabIndex = 28;
            this.btnCWD.Text = "Working Dir";
            this.btnCWD.UseVisualStyleBackColor = true;
            this.btnCWD.Click += new System.EventHandler(this.btnCWD_Click);
            // 
            // btnFW
            // 
            this.btnFW.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFW.Location = new System.Drawing.Point(510, 131);
            this.btnFW.Margin = new System.Windows.Forms.Padding(8);
            this.btnFW.Name = "btnFW";
            this.btnFW.Size = new System.Drawing.Size(200, 54);
            this.btnFW.TabIndex = 27;
            this.btnFW.Text = "Firmware";
            this.btnFW.UseVisualStyleBackColor = true;
            // 
            // btnPartitions
            // 
            this.btnPartitions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPartitions.Location = new System.Drawing.Point(510, 203);
            this.btnPartitions.Margin = new System.Windows.Forms.Padding(8);
            this.btnPartitions.Name = "btnPartitions";
            this.btnPartitions.Size = new System.Drawing.Size(200, 54);
            this.btnPartitions.TabIndex = 26;
            this.btnPartitions.Text = "Partitions";
            this.btnPartitions.UseVisualStyleBackColor = true;
            // 
            // btnBoot_App0
            // 
            this.btnBoot_App0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoot_App0.Location = new System.Drawing.Point(510, 275);
            this.btnBoot_App0.Margin = new System.Windows.Forms.Padding(8);
            this.btnBoot_App0.Name = "btnBoot_App0";
            this.btnBoot_App0.Size = new System.Drawing.Size(200, 54);
            this.btnBoot_App0.TabIndex = 25;
            this.btnBoot_App0.Text = "Boot_App0";
            this.btnBoot_App0.UseVisualStyleBackColor = true;
            // 
            // btnBootloader
            // 
            this.btnBootloader.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBootloader.Location = new System.Drawing.Point(510, 347);
            this.btnBootloader.Margin = new System.Windows.Forms.Padding(8);
            this.btnBootloader.Name = "btnBootloader";
            this.btnBootloader.Size = new System.Drawing.Size(200, 54);
            this.btnBootloader.TabIndex = 24;
            this.btnBootloader.Text = "Boot Loader";
            this.btnBootloader.UseVisualStyleBackColor = true;
            // 
            // txtLookup
            // 
            this.txtLookup.Enabled = false;
            this.txtLookup.Location = new System.Drawing.Point(722, 429);
            this.txtLookup.Margin = new System.Windows.Forms.Padding(4);
            this.txtLookup.Name = "txtLookup";
            this.txtLookup.Size = new System.Drawing.Size(549, 38);
            this.txtLookup.TabIndex = 13;
            // 
            // txtBootloader
            // 
            this.txtBootloader.Enabled = false;
            this.txtBootloader.Location = new System.Drawing.Point(722, 355);
            this.txtBootloader.Margin = new System.Windows.Forms.Padding(4);
            this.txtBootloader.Name = "txtBootloader";
            this.txtBootloader.Size = new System.Drawing.Size(549, 38);
            this.txtBootloader.TabIndex = 17;
            // 
            // btnLookup
            // 
            this.btnLookup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLookup.Location = new System.Drawing.Point(510, 419);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(8);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(200, 54);
            this.btnLookup.TabIndex = 12;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRefreshSerialPorts
            // 
            this.btnRefreshSerialPorts.Location = new System.Drawing.Point(29, 292);
            this.btnRefreshSerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshSerialPorts.Name = "btnRefreshSerialPorts";
            this.btnRefreshSerialPorts.Size = new System.Drawing.Size(386, 78);
            this.btnRefreshSerialPorts.TabIndex = 23;
            this.btnRefreshSerialPorts.Text = "Refresh Serial Ports";
            this.btnRefreshSerialPorts.UseVisualStyleBackColor = true;
            this.btnRefreshSerialPorts.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBootApp0
            // 
            this.txtBootApp0.Enabled = false;
            this.txtBootApp0.Location = new System.Drawing.Point(722, 281);
            this.txtBootApp0.Margin = new System.Windows.Forms.Padding(4);
            this.txtBootApp0.Name = "txtBootApp0";
            this.txtBootApp0.Size = new System.Drawing.Size(549, 38);
            this.txtBootApp0.TabIndex = 20;
            // 
            // btnLoadFW
            // 
            this.btnLoadFW.Location = new System.Drawing.Point(212, 392);
            this.btnLoadFW.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadFW.Name = "btnLoadFW";
            this.btnLoadFW.Size = new System.Drawing.Size(204, 75);
            this.btnLoadFW.TabIndex = 5;
            this.btnLoadFW.Text = "Load FW";
            this.btnLoadFW.UseVisualStyleBackColor = true;
            this.btnLoadFW.Click += new System.EventHandler(this.buttonLoadFW_Click);
            // 
            // txtTestStandID
            // 
            this.txtTestStandID.Location = new System.Drawing.Point(192, 83);
            this.txtTestStandID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestStandID.Name = "txtTestStandID";
            this.txtTestStandID.Size = new System.Drawing.Size(224, 38);
            this.txtTestStandID.TabIndex = 2;
            // 
            // txtPartitions
            // 
            this.txtPartitions.Enabled = false;
            this.txtPartitions.Location = new System.Drawing.Point(722, 207);
            this.txtPartitions.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartitions.Name = "txtPartitions";
            this.txtPartitions.Size = new System.Drawing.Size(549, 38);
            this.txtPartitions.TabIndex = 16;
            // 
            // lblTestStandID
            // 
            this.lblTestStandID.AutoSize = true;
            this.lblTestStandID.Location = new System.Drawing.Point(-4, 89);
            this.lblTestStandID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestStandID.Name = "lblTestStandID";
            this.lblTestStandID.Size = new System.Drawing.Size(186, 32);
            this.lblTestStandID.TabIndex = 6;
            this.lblTestStandID.Text = "Test Stand ID";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(192, 229);
            this.txtBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(224, 38);
            this.txtBaudRate.TabIndex = 11;
            // 
            // txtFW
            // 
            this.txtFW.Enabled = false;
            this.txtFW.Location = new System.Drawing.Point(722, 133);
            this.txtFW.Margin = new System.Windows.Forms.Padding(4);
            this.txtFW.Name = "txtFW";
            this.txtFW.Size = new System.Drawing.Size(549, 38);
            this.txtFW.TabIndex = 12;
            // 
            // txtCWD
            // 
            this.txtCWD.Enabled = false;
            this.txtCWD.Location = new System.Drawing.Point(722, 59);
            this.txtCWD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCWD.Name = "txtCWD";
            this.txtCWD.Size = new System.Drawing.Size(549, 38);
            this.txtCWD.TabIndex = 14;
            // 
            // txtBoardSN
            // 
            this.txtBoardSN.Location = new System.Drawing.Point(192, 132);
            this.txtBoardSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoardSN.Name = "txtBoardSN";
            this.txtBoardSN.Size = new System.Drawing.Size(224, 38);
            this.txtBoardSN.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(92, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblBoardSN
            // 
            this.lblBoardSN.AutoSize = true;
            this.lblBoardSN.Location = new System.Drawing.Point(36, 136);
            this.lblBoardSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoardSN.Name = "lblBoardSN";
            this.lblBoardSN.Size = new System.Drawing.Size(145, 32);
            this.lblBoardSN.TabIndex = 3;
            this.lblBoardSN.Text = "Board S/N";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 38);
            this.txtName.TabIndex = 1;
            // 
            // tbData
            // 
            this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbData.Location = new System.Drawing.Point(4, 35);
            this.tbData.Margin = new System.Windows.Forms.Padding(8);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(1292, 368);
            this.tbData.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbData);
            this.groupBox4.Location = new System.Drawing.Point(58, 561);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1300, 407);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progress Monitor";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnLoadFW;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnLookup;
            this.ClientSize = new System.Drawing.Size(2504, 1393);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 6, 16, 6);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnLoadFW;
        private System.Windows.Forms.TextBox txtBoardSN;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBoardSN;
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
    }
}

