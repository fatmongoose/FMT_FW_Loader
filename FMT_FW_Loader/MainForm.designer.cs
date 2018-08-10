﻿namespace FMT_FW_Loader
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
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LineCountBox = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btn_ShowFile = new System.Windows.Forms.Button();
            this.idData = new System.Windows.Forms.TextBox();
            this.txtLoadComplete = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLoadFW = new System.Windows.Forms.Button();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWebRefresh = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnRefreshSerialPorts = new System.Windows.Forms.Button();
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
            this.regionNameBox = new System.Windows.Forms.ComboBox();
            this.whitelistLoadButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.whitelistConfirmed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(24, 89);
            this.baudRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(75, 17);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Baud Rate";
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Location = new System.Drawing.Point(24, 65);
            this.portNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(75, 17);
            this.portNameLabel.TabIndex = 7;
            this.portNameLabel.Text = "Port Name";
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(104, 64);
            this.portNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(114, 24);
            this.portNameComboBox.TabIndex = 4;
            this.portNameComboBox.SelectedIndexChanged += new System.EventHandler(this.portNameComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.whitelistConfirmed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LineCountBox);
            this.groupBox1.Controls.Add(this.whitelistLoadButton);
            this.groupBox1.Controls.Add(this.btnRestart);
            this.groupBox1.Controls.Add(this.btn_ShowFile);
            this.groupBox1.Controls.Add(this.idData);
            this.groupBox1.Controls.Add(this.regionNameBox);
            this.groupBox1.Controls.Add(this.txtLoadComplete);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnLoadFW);
            this.groupBox1.Controls.Add(this.portNameComboBox);
            this.groupBox1.Controls.Add(this.txtBaudRate);
            this.groupBox1.Controls.Add(this.portNameLabel);
            this.groupBox1.Controls.Add(this.txtDeviceID);
            this.groupBox1.Controls.Add(this.baudRateLabel);
            this.groupBox1.Controls.Add(this.lblDeviceID);
            this.groupBox1.Location = new System.Drawing.Point(31, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(819, 267);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "V1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Number Scanned:";
            // 
            // LineCountBox
            // 
            this.LineCountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineCountBox.Location = new System.Drawing.Point(567, 180);
            this.LineCountBox.Name = "LineCountBox";
            this.LineCountBox.ReadOnly = true;
            this.LineCountBox.Size = new System.Drawing.Size(28, 15);
            this.LineCountBox.TabIndex = 29;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(605, 168);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(184, 39);
            this.btnRestart.TabIndex = 28;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btn_ShowFile
            // 
            this.btn_ShowFile.Location = new System.Drawing.Point(241, 168);
            this.btn_ShowFile.Name = "btn_ShowFile";
            this.btn_ShowFile.Size = new System.Drawing.Size(184, 39);
            this.btn_ShowFile.TabIndex = 27;
            this.btn_ShowFile.Text = "Show File In Explorer";
            this.btn_ShowFile.UseVisualStyleBackColor = true;
            this.btn_ShowFile.Click += new System.EventHandler(this.btn_ShowFile_Click);
            // 
            // idData
            // 
            this.idData.Location = new System.Drawing.Point(241, 17);
            this.idData.Margin = new System.Windows.Forms.Padding(4);
            this.idData.Multiline = true;
            this.idData.Name = "idData";
            this.idData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.idData.Size = new System.Drawing.Size(548, 144);
            this.idData.TabIndex = 25;
            // 
            // txtLoadComplete
            // 
            this.txtLoadComplete.Location = new System.Drawing.Point(23, 176);
            this.txtLoadComplete.Name = "txtLoadComplete";
            this.txtLoadComplete.Size = new System.Drawing.Size(193, 22);
            this.txtLoadComplete.TabIndex = 24;
            this.txtLoadComplete.Text = "Load Complete";
            this.txtLoadComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoadComplete.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 175);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(193, 23);
            this.progressBar1.Step = 45;
            this.progressBar1.TabIndex = 23;
            // 
            // btnLoadFW
            // 
            this.btnLoadFW.Location = new System.Drawing.Point(71, 122);
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
            this.txtBaudRate.Location = new System.Drawing.Point(104, 89);
            this.txtBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(114, 22);
            this.txtBaudRate.TabIndex = 11;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(104, 39);
            this.txtDeviceID.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeviceID.MaxLength = 8;
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(114, 22);
            this.txtDeviceID.TabIndex = 3;
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Location = new System.Drawing.Point(26, 41);
            this.lblDeviceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(68, 17);
            this.lblDeviceID.TabIndex = 3;
            this.lblDeviceID.Text = "Device ID\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Load Names";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnWebRefresh
            // 
            this.btnWebRefresh.Location = new System.Drawing.Point(655, 121);
            this.btnWebRefresh.Name = "btnWebRefresh";
            this.btnWebRefresh.Size = new System.Drawing.Size(128, 39);
            this.btnWebRefresh.TabIndex = 26;
            this.btnWebRefresh.Text = "Refresh Web ";
            this.btnWebRefresh.UseVisualStyleBackColor = true;
            this.btnWebRefresh.Visible = false;
            this.btnWebRefresh.Click += new System.EventHandler(this.btnWebRefresh_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(654, 169);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(102, 39);
            this.btnClearList.TabIndex = 23;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Visible = false;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnRefreshSerialPorts
            // 
            this.btnRefreshSerialPorts.Location = new System.Drawing.Point(654, 67);
            this.btnRefreshSerialPorts.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshSerialPorts.Name = "btnRefreshSerialPorts";
            this.btnRefreshSerialPorts.Size = new System.Drawing.Size(193, 40);
            this.btnRefreshSerialPorts.TabIndex = 23;
            this.btnRefreshSerialPorts.Text = "Refresh Serial Ports";
            this.btnRefreshSerialPorts.UseVisualStyleBackColor = true;
            this.btnRefreshSerialPorts.Visible = false;
            this.btnRefreshSerialPorts.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox4.Controls.Add(this.btnRefreshSerialPorts);
            this.groupBox4.Controls.Add(this.btnClearList);
            this.groupBox4.Controls.Add(this.btnWebRefresh);
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
            this.groupBox4.Location = new System.Drawing.Point(31, 288);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(1286, 343);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progress Monitor";
            this.groupBox4.Visible = false;
            // 
            // regionNameBox
            // 
            this.regionNameBox.FormattingEnabled = true;
            this.regionNameBox.Location = new System.Drawing.Point(241, 213);
            this.regionNameBox.MaxDropDownItems = 50;
            this.regionNameBox.Name = "regionNameBox";
            this.regionNameBox.Size = new System.Drawing.Size(407, 24);
            this.regionNameBox.TabIndex = 32;
            // 
            // whitelistLoadButton
            // 
            this.whitelistLoadButton.Location = new System.Drawing.Point(660, 213);
            this.whitelistLoadButton.Name = "whitelistLoadButton";
            this.whitelistLoadButton.Size = new System.Drawing.Size(129, 24);
            this.whitelistLoadButton.TabIndex = 33;
            this.whitelistLoadButton.Text = "Load Whitelist";
            this.whitelistLoadButton.UseVisualStyleBackColor = true;
            this.whitelistLoadButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1105, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Make Table";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(970, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "mkSpiffs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Whitelist";
            // 
            // whitelistConfirmed
            // 
            this.whitelistConfirmed.AutoSize = true;
            this.whitelistConfirmed.Location = new System.Drawing.Point(386, 240);
            this.whitelistConfirmed.Name = "whitelistConfirmed";
            this.whitelistConfirmed.Size = new System.Drawing.Size(116, 17);
            this.whitelistConfirmed.TabIndex = 35;
            this.whitelistConfirmed.Text = "Whitelist Loaded!";
            this.whitelistConfirmed.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(1523, 545);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 3, 8, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "FMT FWL";
            this.Text = "FMT FW Loader ";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.TextBox txtLoadComplete;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.TextBox idData;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Button btnWebRefresh;
        private System.Windows.Forms.Button btn_ShowFile;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LineCountBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox regionNameBox;
        private System.Windows.Forms.Button whitelistLoadButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label whitelistConfirmed;
    }
}

