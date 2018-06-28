using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FMT_FW_Loader.Serial;
using System.IO;
using TestData.TD;
using System.Threading;
//using TSA_DLL_TEST;
using Detector;



//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using SerialPortListener.Serial;
//using System.IO;
//using System.IO.Ports;
//using TestData.TD;
//using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
//using System.Text;
using System.Net;
using System.Drawing;
//using System.Collections.Specialized;
using System.Numerics;
using System.Diagnostics;



namespace FMT_FW_Loader
{
    public partial class MainForm : Form
    {
        SerialPortManager _spManager;
        TestDataRec _testdata;

        static string cd = Directory.GetCurrentDirectory();

        public MainForm()
        {
            InitializeComponent();

            UserInitialization();
        }


        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            //_testdata = new TestDataRec();

            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            serialSettingsBindingSource.DataSource = mySerialSettings;
            portNameComboBox.DataSource = mySerialSettings.PortNameCollection;
            txtBaudRate.Text = mySerialSettings.BaudRate.ToString();

            initializeForTest();

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Read_Data_Thread_Abort();
            _spManager.Dispose();
        }

       
        // Handles the "Stop Listening"-buttom click event
        private void btnStop_Click(object sender, EventArgs e)
        {

            //_spManager.StopListening();

            try
            {

                //// Displays an OpenFileDialog so the user can select a Cursor.  
                //OpenFileDialog openFileDialog1 = new OpenFileDialog();
                //openFileDialog1.Filter = "Lookup Table Files|*.bin";
                //openFileDialog1.Title = "Select a Binary Lookup File";

                //// Show the Dialog.  
                //// If the user clicked OK in the dialog and  
                //// a .BIN file was selected.  
                //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    // Assign the cursor in the Stream to the Form's Cursor property.  
                //    this.Cursor = new Cursor(openFileDialog1.OpenFile());
                //}



                //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    System.IO.StreamReader sr = new
                //       System.IO.StreamReader(openFileDialog1.FileName);
                //    MessageBox.Show(sr.ReadToEnd());
                //    sr.Close();
                //}
            }
            finally
            {

            }
        }

        private void buttonLoadFW_Click(object sender, EventArgs e)
        {
            try
            {

                //check for Name and Test Station ID
                if (_spManager.CurrentSerialSettings.PortNameCollection == null)
                {
                    //this where we need to not to do anything until the right fields are filled. 
                    MessageBox.Show("DeviceID or COM port is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                progressBar1.Value = 45;

                _testdata.TesterName = txtName.Text;
                _testdata.TestStandID = txtTestStandID.Text;
                _testdata.DeviceID = txtDeviceID.Text;

                string target = "firmware\\esptool.exe";
                string filename = Path.Combine(txtCWD.Text.ToString(), target);


                //String fw_directory = "C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware";
                //String filename = "C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\esptool.exe";
                // Get the current directory.
                //                string DIR_PATH = Application.StartupPath;//String commandline_old = "C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\esptool --chip esp32 --port COM4 --baud 921600 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect 0xe000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\boot_app0.bin 0x1000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\bootloader_qio_80m.bin 0x10000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_firmware.bin 0x8000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_partitions.bin";
                //String commandline_6_4_10 = "C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\esptool --chip esp32 --port COM4 --baud 921600 
                //--before default_reset --after hard_reset write_flash -z --flash_mode dio 
                //--flash_freq 80m 
                //--flash_size detect 

                //0x1F000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\lookup.bin 
                //0xe000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\boot_app0.bin 
                //0x1000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\bootloader_qio_80m.bin 
                //0x10000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_firmware.bin 
                //0x8000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_partitions.bin";
                //C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\esptool --chip esp32 --port COM4 --baud 921600 --chip esp32 --port COM18 --baud 921600 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect 0x1F0000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\lookup.bin 0xe000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\boot_app0.bin 0x1000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\bootloader_qio_80m.bin 0x10000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_firmware.bin 0x8000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_partitions.bin
                //                String arguments = " --chip esp32 --port " + _spManager.CurrentSerialSettings.PortName.ToString() + " --baud " + _spManager.CurrentSerialSettings.BaudRate.ToString() + " --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect 0x1F0000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\lookup.bin 0xe000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\boot_app0.bin 0x1000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\bootloader_qio_80m.bin 0x10000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_firmware.bin 0x8000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_partitions.bin";


                string arguments = " --chip esp32 --port " + _spManager.CurrentSerialSettings.PortName.ToString() +
                    " --baud " + _testdata._prog_baudRate.ToString() +
                    " --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect" +
                    " 0x1F0000 " + txtLookup.Text.ToString() +
                    " 0xe000 " + txtBootApp0.Text.ToString() +
                    " 0x1000 " + txtBootloader.Text.ToString() +
                    " 0x10000 " + txtFW.Text.ToString() +
                    " 0x8000 " + txtPartitions.Text.ToString();
                //            C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\esptool --chip esp32 --port COM4 --baud 921600 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect 0xe000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\boot_app0.bin 0x1000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\bootloader_qio_80m.bin 0x10000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_firmware.bin 0x8000 C:\\Users\\bf\\Documents\\PlatformIO\\Projects\\personalAlarm3_4_FunctionalTest\\firmware\\PersonalAlarm3_3_partitions.bin

                Process proc = new Process();
                proc.StartInfo.FileName = filename;
                proc.StartInfo.Arguments = arguments;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.UseShellExecute = false;// true;
                                                       // Stop the process from opening a new window
                proc.StartInfo.CreateNoWindow = true;
                proc.EnableRaisingEvents = true;
                // Set event handler
                proc.OutputDataReceived += new DataReceivedEventHandler(procOutputHandler);
                proc.Exited += Proc_Exited;

                proc.Start();
                progressBar1.Value = 90;
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();

                while (!proc.HasExited)
                {
                    Application.DoEvents(); // This keeps your form responsive by processing events
                }

            }
            finally
            {
                //proc.Close();
            }

            _spManager.CurrentSerialSettings.BaudRate = _testdata._baudRate;
            txtBaudRate.Text = _testdata._baudRate.ToString();

            _spManager.StartListening();
            
        }

        private void Proc_Exited(object sender, EventArgs e)
        {
            if ((progressBar1.Value < 900) && (progressBar1.Value > 90))
            {
                MessageBox.Show("The firmware upload process has been interrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void procOutputHandler(object sender, DataReceivedEventArgs e)
        {
            Trace.WriteLine(e.Data);
            this.BeginInvoke(new MethodInvoker(() =>
            {
                string temp = e.Data;

                if (!(string.IsNullOrEmpty(temp)))
                {
                    tbData.AppendText(temp + "\r\n");
                    tbData.ScrollToCaret();

                    if (
                    temp.Contains("(1 %)") || temp.Contains("(2 %)") || 
                    temp.Contains("(3 %)") || temp.Contains("(4 %)") ||
                    temp.Contains("(5 %)")
                        )
                    {
                        progressBar1.Value = 135;
                    }
                    if (
                    temp.Contains("(6 %)") || temp.Contains("(7 %)") ||
                    temp.Contains("(8 %)") || temp.Contains("(9 %)") ||
                    temp.Contains("(10 %)")
                        )
                    {
                        progressBar1.Value = 180;
                    }
                    if (
                    temp.Contains("(11 %)") || temp.Contains("(12 %)") ||
                    temp.Contains("(13 %)") || temp.Contains("(14 %)") ||
                    temp.Contains("(15 %)")
                        )
                    {
                        progressBar1.Value = 225;
                    }
                    if (
                    temp.Contains("(16 %)") || temp.Contains("(17 %)") ||
                    temp.Contains("(18 %)") || temp.Contains("(19 %)") ||
                    temp.Contains("(20 %)")
                        )
                    {
                        progressBar1.Value = 270;
                    }
                    if (
                    temp.Contains("(21 %)") || temp.Contains("(22 %)") ||
                    temp.Contains("(23 %)") || temp.Contains("(24 %)") ||
                    temp.Contains("(25 %)")
                        )
                    {
                        progressBar1.Value = 315;
                    }
                    if (
                    temp.Contains("(26 %)") || temp.Contains("(27 %)") ||
                    temp.Contains("(28 %)") || temp.Contains("(29 %)") ||
                    temp.Contains("(30 %)")
                        )
                    {
                        progressBar1.Value = 360;
                    }
                    if (
                    temp.Contains("(31 %)") || temp.Contains("(32 %)") ||
                    temp.Contains("(33 %)") || temp.Contains("(34 %)") ||
                    temp.Contains("(35 %)")
                        )
                    {
                        progressBar1.Value = 405;
                    }
                    if (
                    temp.Contains("(36 %)") || temp.Contains("(37 %)") ||
                    temp.Contains("(38 %)") || temp.Contains("(39 %)") ||
                    temp.Contains("(40 %)")
                        )
                    {
                        progressBar1.Value = 450;
                    }
                    if (
                    temp.Contains("(41 %)") || temp.Contains("(42 %)") ||
                    temp.Contains("(43 %)") || temp.Contains("(44 %)") ||
                    temp.Contains("(45 %)")
                        )
                    {
                        progressBar1.Value = 495;
                    }
                    if (
                    temp.Contains("(46 %)") || temp.Contains("(47 %)") ||
                    temp.Contains("(48 %)") || temp.Contains("(49 %)") ||
                    temp.Contains("(50 %)")
                        )
                    {
                        progressBar1.Value = 540;
                    }
                    if (
                    temp.Contains("(51 %)") || temp.Contains("(52 %)") ||
                    temp.Contains("(53 %)") || temp.Contains("(54 %)") ||
                    temp.Contains("(55 %)")
                        )
                    {
                        progressBar1.Value = 585;
                    }
                    if (
                    temp.Contains("(56 %)") || temp.Contains("(57 %)") ||
                    temp.Contains("(58 %)") || temp.Contains("(59 %)") ||
                    temp.Contains("(60 %)")
                        )
                    {
                        progressBar1.Value = 630;
                    }
                    if (
                    temp.Contains("(61 %)") || temp.Contains("(62 %)") ||
                    temp.Contains("(63 %)") || temp.Contains("(64 %)") ||
                    temp.Contains("(65 %)")
                        )
                    {
                        progressBar1.Value = 675;
                    }
                    if (
                    temp.Contains("(66 %)") || temp.Contains("(67 %)") ||
                    temp.Contains("(68 %)") || temp.Contains("(69 %)") ||
                    temp.Contains("(70 %)")
                        )
                    {
                        progressBar1.Value = 720;
                    }
                    if (
                    temp.Contains("(71 %)") || temp.Contains("(72 %)") ||
                    temp.Contains("(73 %)") || temp.Contains("(74 %)") ||
                    temp.Contains("(75 %)")
                        )
                    {
                        progressBar1.Value = 765;
                    }
                    if (
                    temp.Contains("(76 %)") || temp.Contains("(77 %)") ||
                    temp.Contains("(78 %)") || temp.Contains("(79 %)") ||
                    temp.Contains("(80 %)")
                        )
                    {
                        progressBar1.Value = 810;
                    }
                    if (
                    temp.Contains("(81 %)") || temp.Contains("(82 %)") ||
                    temp.Contains("(83 %)") || temp.Contains("(84 %)") ||
                    temp.Contains("(85 %)")
                        )
                    {
                        progressBar1.Value = 855;
                    }
                    if (
                    temp.Contains("(86 %)") || temp.Contains("(87 %)") ||
                    temp.Contains("(88 %)") || temp.Contains("(89 %)") ||
                    temp.Contains("(90 %)")
                        )
                    {
                        progressBar1.Value = 900;
                    }
                    if (
                    temp.Contains("(91 %)") || temp.Contains("(92 %)") ||
                    temp.Contains("(93 %)") || temp.Contains("(94 %)") ||
                    temp.Contains("(95 %)")
                        )
                    {
                        progressBar1.Value = 945;
                    }

                    if (temp.Contains("Hard resetting via RTS pin"))
                    {
                        progressBar1.Value = 1000;
                    }
                } 
                
            }
            )
            );
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            //_spManager.SendString(txtToSend.Text.ToString());
        }



        private void buttonOneScan_Click(object sender, EventArgs e)
        {
            txtLookup.Text = "B1351B75DDD3815A";
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            _spManager.refreshPorts();
        }


        private void initializeForTest()
        {
            cd = Directory.GetCurrentDirectory();
            //clear out any old test data
            _testdata = new TestDataRec();

            // check to see if we need to do this....                 _testdata._testState = 0;

            tbData.Clear();

            txtBaudRate.Clear();
 //           txtDeviceID.Clear();
            txtLookup.Clear();
            txtFW.Clear();
            txtCWD.Clear();
            txtPartitions.Clear();
            txtBootloader.Clear();
            txtDeviceID.Clear();
            txtBootApp0.Clear();

            txtBaudRate.Enabled = false;
//            txtDeviceID.Enabled = false;
            txtLookup.Enabled = true;
            txtFW.Enabled = true;
            txtCWD.Enabled = true;
            txtPartitions.Enabled = true;
            txtBootloader.Enabled = true;
            txtBootApp0.Enabled = true;



            //groupBox2.Text = "Results";

            //groupBox2.ForeColor = SystemColors.ControlText;
            txtBaudRate.ForeColor = SystemColors.WindowText;
//            txtDeviceID.ForeColor = SystemColors.WindowText;
            txtLookup.ForeColor = SystemColors.WindowText;
            txtFW.ForeColor = SystemColors.WindowText;
            txtCWD.ForeColor = SystemColors.WindowText;
            txtPartitions.ForeColor = SystemColors.WindowText;
            txtBootloader.ForeColor = SystemColors.WindowText;
            txtBootApp0.ForeColor = SystemColors.WindowText;


            txtCWD.Text = Directory.GetCurrentDirectory();


  //          openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;

            txtLookup.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\lookup.bin").ToString();
            txtBootApp0.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\boot_app0.bin").ToString();
           txtBootloader.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\bootloader_qio_80m.bin").ToString();
            txtFW.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\firmware.bin").ToString();
            txtPartitions.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\partitions.bin").ToString();

            //0x1F0000 " + txtLookup.Text.ToString() +
            //        " 0xe000 " + txtBootApp0.Text.ToString() +
            //        " 0x1000 " + txtBootloader.Text.ToString() +
            //        " 0x10000 " + txtFW.Text.ToString() +
            //        " 0x8000 " + txtPartitions.ToString();

            //maybe pick a diectory where the right files should be instead of picking each file individually??


            _spManager.CurrentSerialSettings.BaudRate = _testdata._prog_baudRate;
            txtBaudRate.Text = _testdata._prog_baudRate.ToString();


        }



        private void postResults()
        {
            // Serialize JSON test data.

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TestDataRec));


            ser.WriteObject(stream1, _testdata);

            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);

            // POST the serialized JSON test data. 
            var request = (HttpWebRequest)WebRequest.Create("https://sf.fatmongoose.com/sf/personalarmtest");
            //var request = (HttpWebRequest)WebRequest.Create("https://webhook.site/a64dca6f-7df8-475f-8485-700e4da61ee6");
            //StreamReader sr = new StreamReader(data);
            string postData = sr.ReadToEnd();

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = postData.Length;

            using (var stream = new StreamWriter(request.GetRequestStream()))
            {
                stream.Write(postData);
            }

            var response = (HttpWebResponse)request.GetResponse();
            tbData.AppendText("response " + response.ToString() + "\r\n");

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            tbData.AppendText("responseString " + responseString.ToString() + "\r\n");

        }



        private void portNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

            int maxTextLength = 100000; // maximum text length in text box
            if (tbData.TextLength > maxTextLength)
            {
                tbData.Text = tbData.Text.Remove(0, tbData.TextLength - maxTextLength);
            }
            // ASCII data is converted to text
            //           string str = Encoding.ASCII.GetString(e.Data);
            //           tbData.AppendText(str);
            string str = e.Str;
            tbData.AppendText(str + "\r\n");
            tbData.ScrollToCaret();

            /************************* START THE TEST **************************************/
            //wait for this string to pop up, "FMT personalAlarm!"
            //then send the "SELFTEST-SECRETKEY"
            if (str.Contains("FMT personalAlarm!") & (_testdata._testState == 0))
            {
                //_spManager.SendString("SELFTEST-SECRETKEY");
                //_testdata._testState = 1;
            }

            /********************** CODE SECTION TO GATHER ARBITRARY TEXT DATA FROM SERIAL STREAM ***************************************/

         

            //get the deviceID                  Device ID: 002C1E76

            if (str.Contains("Device ID:") & (_testdata._testState == 1))
            {
                char[] arr = str.Where(c => (char.IsLetterOrDigit(c) ||
                             char.IsWhiteSpace(c) ||
                             c == '-')).ToArray();

                str = new string(arr);
                _testdata.DeviceID = str.Substring(str.Length - 9);
              //  txtDeviceID.Text = _testdata.DeviceID.ToString();
            }




            ////detect ButtonPress and decide if button press is done.             [INFO] Button State is 0
            ////if the popup box is open and the string "alarm_mode: OFF...Stay put fool!"

            //if (str.Contains("alarm_mode:  OFF... Stay put fool!") & (_testdata._testState == 1))
            //{
            //    //this means the user has pressed the buttons and the alarm turned off. 
            //    //So if both buttons were detected low to start, BUTTON PRESS TEST IS a PASS. 
            //    if ((_testdata._button_state_0_detected == true) & (_testdata.initBtnState == 0))
            //    {
            //        _testdata.ButtonPressTest = true;
            //        txtBootApp0.Text = "PASS";
            //        txtBootApp0.ForeColor = System.Drawing.Color.Green;//   
            //    }

            //    else
            //    {
            //        _testdata.ButtonPressTest = false;
            //        txtBootApp0.Text = "FAIL";
            //        txtBootApp0.ForeColor = System.Drawing.Color.Red;//   
            //    }


            //    _testdata._testState = 2;
            _spManager.StopListening();



                //clear the text box that tells them to press the buttons. 

                //poll the user to see if the leds and audio worked? 
                //DialogResult response = MessageBox.Show("Did you see the GREEN, RED and BLUE LED's and did the speaker work during the test?",
                //    "Observation Question",
                //    MessageBoxButtons.YesNo,
                //    MessageBoxIcon.Question,
                //    MessageBoxDefaultButton.Button1);
                //if (response == DialogResult.Yes)
                //{
                //    _testdata.LedAudioTest = true;
                //    txtBootloader.Text = "PASS";
                //    txtBootloader.ForeColor = System.Drawing.Color.Green;//   
                //}
                //else
                //{
                //    _testdata.LedAudioTest = false;
                //    txtBootloader.Text = "FAIL";
                //    txtBootloader.ForeColor = System.Drawing.Color.Red;//   
                //}




                //_testdata.Text = tbData.Text;
                //postResults();



                //clear any exisitng test data
                initializeForTest();
                // set focus to txtBoardSN
                this.ActiveControl = txtDeviceID;

            //}


        }

        //private static double RtlCmd()
        //{
        //    double cfreq = 900; // Center frequency in MHz.
        //    string rtlCmd = " -f " + cfreq.ToString() + "e6 -s 240e3 -n 1e3 -d 1 " + cd + "\\tempout";

        //    Process proc = new Process();
        //    ProcessStartInfo startInfo = new ProcessStartInfo
        //    {
        //        // Hide the command window.
        //        WindowStyle = ProcessWindowStyle.Hidden,
        //        // Use the command line.
        //        FileName = cd + "\\rtl_sdr.exe",
        //        Arguments = rtlCmd
        //    };
        //    proc.StartInfo = startInfo;
        //    proc.StartInfo.RedirectStandardOutput = true;
        //    proc.StartInfo.RedirectStandardError = false;
        //    proc.StartInfo.UseShellExecute = false;// true;
        //                                           // Stop the process from opening a new window
        //    proc.StartInfo.CreateNoWindow = true;
        //    proc.EnableRaisingEvents = true;
        //    proc.Start();
        //    //string output = proc.StandardOutput.ReadToEnd();
        //    //return output;

        //    return cfreq;
        //}

        private static void Delay(double sec)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.Elapsed.TotalSeconds < sec)
            {
                // Delay.
            }
            sw.Stop();
        }

        private void btnCWD_Click(object sender, EventArgs e)
        {

        }

        private void lblDeviceID_Click(object sender, EventArgs e)
        {

        }

        private void txtDeviceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}


