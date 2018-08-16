using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FMT_FW_Loader.Serial;
using System.IO;
using TestData.TD;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


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
            this.Text = ("FMT FW Loader " + Directory.GetCurrentDirectory().ToString());
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

            nameCollect();

            groupBox2.BringToFront();
            groupBox1.SendToBack();

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }

        // Handles the "Stop Listening"-buttom click event
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
            }
            finally
            {
            }
        }

        private void buttonLoadFW_Click(object sender, EventArgs e)
        {
            try
            {
                _spManager.refreshPorts();

                txtDeviceID.CharacterCasing = CharacterCasing.Upper;
                txtLoadComplete.Visible = false;

                _spManager.StartListening();

                //txtDeviceID.Text = getID();
                //if ((_spManager.CurrentSerialSettings.PortNameCollection == null) || String.IsNullOrEmpty(txtDeviceID.Text.ToString()) == true)
                //{
                //    //this where we need to not to do anything until the right fields are filled. 
                //    MessageBox.Show("DeviceID or COM port is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                progressBar1.Value = 45;

                //_testdata.DeviceID = txtDeviceID.Text;

                _spManager.StopListening();

                string target = "firmware\\esptool.exe";
                string filename = Path.Combine(txtCWD.Text.ToString(), target);
                

                string arguments = " --chip esp32 --port " + _spManager.CurrentSerialSettings.PortName.ToString() +
                    " --baud " + _testdata._prog_baudRate.ToString() +
                    " --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect" +
                    " 0x1F0000 " + txtLookup.Text.ToString() +
                    " 0xe000 " + txtBootApp0.Text.ToString() +
                    " 0x1000 " + txtBootloader.Text.ToString() +
                    " 0x10000 " + txtFW.Text.ToString() +
                    " 0x8000 " + txtPartitions.Text.ToString();
                
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
                    temp.Contains("(48 %)") || temp.Contains("(49 %)")
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
                    temp.Contains("(73 %)") || temp.Contains("(74 %)")
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
                } 
            }
            )
            );
        }

        private void butSend_Click(object sender, EventArgs e)
        {
        }
        
        private void buttonOneScan_Click(object sender, EventArgs e)
        {
            //txtLookup.Text = "B1351B75DDD3815A";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            _spManager.refreshPorts();
        }
        
        private void initializeForTest()
        {
            if (!File.Exists(cd + "\\firmware\\idData.txt"))
            {
                File.Create(cd + "\\firmware\\idData.txt").Close();
            }
            //clear out any old test data
            _testdata = new TestDataRec();
            cd = Directory.GetCurrentDirectory();

            WebClient client = new WebClient();

            MemoryStream memoryStream = new MemoryStream();
            using (Stream input = client.OpenRead("https://sf.fatmongoose.com/sf/pwc/"))
            {
                input.CopyTo(memoryStream);
            }
            memoryStream.Position = 0;

            StreamReader reader = new StreamReader(memoryStream);
            _testdata.content = reader.ReadToEnd();

            reader.BaseStream.Position = 0;
            // check to see if we need to do this....                 _testdata._testState = 0;

            tbData.Clear();
            idData.Clear();
            
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(cd + "\\firmware\\idData.txt");

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                idData.AppendText(line + "\r\n");
            }

            int lineCount = File.ReadAllLines(cd + "\\firmware\\idData.txt").Count();
            LineCountBox.Text = lineCount.ToString();

            txtBaudRate.Clear();
            txtDeviceID.Clear();
            txtLookup.Clear();
            txtFW.Clear();
            txtCWD.Clear();
            txtPartitions.Clear();
            txtBootloader.Clear();
            txtDeviceID.Clear();
            txtBootApp0.Clear();
            
            txtCWD.Text = Directory.GetCurrentDirectory();
            
            txtLookup.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\lookup.bin").ToString();
            txtBootApp0.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\boot_app0.bin").ToString();
            txtBootloader.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\bootloader_qio_80m.bin").ToString();
            txtFW.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\firmware.bin").ToString();
            txtPartitions.Text = Path.Combine(txtCWD.Text.ToString(), "firmware\\partitions.bin").ToString();
            
            _spManager.CurrentSerialSettings.BaudRate = _testdata._prog_baudRate;
            txtBaudRate.Text = _testdata._prog_baudRate.ToString();

            // set focus
            this.ActiveControl = btnLoadFW;
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

        /********** Variables for whitelists **********/
        string fullRead;
        string JSessionID;
        string propListPage;
        string responseFromList;
        string[] nameArray;
        JArray parsedList;
        string whitelistText;
        string devIDreturned;

        private void nameCollect()
        {
            /********** Use FMT credentials to log into Umajin. **********/

            var loginReq = (HttpWebRequest)WebRequest.Create("http://dora.umajin.com/login.php");
            loginReq.Method = "POST";
            loginReq.ContentType = "application/x-www-form-urlencoded";
            string user = "fmt";
            string pass = "hadsk%2A%26%5Ee2jHZgda32";
            string token = "26a05b8635ee9f74cc86e59cc658f424";

            using (StreamWriter writer = new StreamWriter(loginReq.GetRequestStream()))
            {
                writer.Write("username=" + user + "&password=" + pass + "&project_token=" + token);
                // hard-coded at the moment for proof of concept, can add converter
            }
            HttpWebResponse response = (HttpWebResponse)loginReq.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                fullRead = reader.ReadToEnd();
            }

            /********** Separate the JSessionID. **********/

            var data = (JObject)JsonConvert.DeserializeObject(fullRead);
            JSessionID = data["JSESSIONID"].Value<string>();

            propListPage = "http://dora.umajin.com/api/1.0/list-properties.php?JSESSIONID=" + JSessionID;

            /********** Find properties list. **********/

            var listReq = (HttpWebRequest)WebRequest.Create(propListPage);
            HttpWebResponse listResponse = (HttpWebResponse)listReq.GetResponse();
            Stream datastream = listResponse.GetResponseStream();
            StreamReader readListResponse = new StreamReader(datastream);
            responseFromList = readListResponse.ReadToEnd();
            
            /********** Load properties' names to the combo box. **********/
            
            parsedList = JArray.Parse(responseFromList);
            List<string> nameList = new List<string>();
            nameList.Add("Marriott (Full Client List)");
            nameList.Add("Hilton (Full Client List)");
            nameList.Add("Marcus (Full Client List)");
            nameList.Add("Sage (Full Client List)");
            foreach (var item in parsedList.Children())
            {
                string name = item["property_name"].Value<string>();
                nameList.Add(name);
            }
            nameArray = nameList.ToArray();
            regionNameBox.DataSource = nameArray;
        }

        private void whitelistCollect()
        {
            string url = "";
            foreach (var item in parsedList.Children())
            {
                if (regionNameBox.SelectedIndex > 3)
                {
                    if (item["property_name"].Value<string>() == (string)regionNameBox.SelectedItem)
                    {
                        url = item["url"].Value<string>();
                    }
                }  else if (regionNameBox.SelectedIndex == 3) {
                    string baseUrl = "https://dora.umajin.com/api/1.0/get-whitelist.php?clientid=";
                    url = baseUrl + 1 + "&JSESSIONID=" + JSessionID;
                }  else  {
                    int clientid = (regionNameBox.SelectedIndex + 1);
                    string baseUrl = "https://dora.umajin.com/api/1.0/get-whitelist.php?clientid=";
                    url = baseUrl + clientid + "&JSESSIONID=" + JSessionID;
                }
            }

            var whitelistReq = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse whitelistResponse = (HttpWebResponse)whitelistReq.GetResponse();
            Stream whitelistData = whitelistResponse.GetResponseStream();
            StreamReader readWhitelist = new StreamReader(whitelistData);
            whitelistText = readWhitelist.ReadToEnd();
        }

        private void makeListFile()
        {
            string tablePath = cd + "\\firmware\\image\\table.txt";
            if (File.Exists(tablePath))
            {
                File.Delete(tablePath);
            }
            File.Create(tablePath).Close();
            
            File.WriteAllText(tablePath, whitelistText);
        }

        private void MkSpiffs()
        {
            if (File.Exists(cd + "\\firmware\\image\\table.txt"))
            {
                string mksp = " -c ./image -p 256 -b 4096 -s 1966080 -d 5 lookup.bin";

                Process proc = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    // Make the working directory the firmware directory so that the right file is overwritten.
                    WorkingDirectory = cd + "\\firmware",
                    // Use the mkSpiffs executable.
                    FileName = cd + "\\firmware\\mkspiffs-0.2.3-arduino-esp32-win32.exe",
                    Arguments = mksp
                };
                proc.StartInfo = startInfo;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = false;
                proc.StartInfo.UseShellExecute = false;

                proc.StartInfo.CreateNoWindow = true;
                proc.EnableRaisingEvents = true;
                proc.Start();
            }
            else
            {
                //Do not run mkSpiffs, use existing lookup.bin.
            }
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
            
            string str = (e.Str + "\r\n");
            tbData.AppendText(str);
            tbData.ScrollToCaret();


            /************************************** Verify the boot **************************************/
            // If one of these phrases comes through the serial port, then the boot is verified.
            int versiontime = 0;
            int foundit = 0;

            if (str.Contains("version"))
            {
                foundit = 1;

                Regex rx = new Regex("deviceid");
                foreach (Match match in rx.Matches(str))
                {
                    int i = match.Index;
                    devIDreturned = str.Substring(i + 12, 8);
                    //tbData.AppendText(devIDreturned + "\r\n");
                    txtDeviceID.Text = devIDreturned;
                }
            }
            if (str.Contains("FMT personalAlarm"))
            {
                versiontime = 1;
            }
            if (foundit == 1)
            {
                tbData.AppendText("Found it!");
                string temp = _testdata.content.ToString();
                Regex rx = new Regex(txtDeviceID.Text.ToString());
                foreach (Match match in rx.Matches(temp))
                {
                    int i = match.Index;
                    // idData.AppendText("\r\n" + i.ToString());
                    idData.AppendText(temp.Substring(i, 25) + "\r\n");
                }

                progressBar1.Value = 1000;
                txtLoadComplete.Visible = true;
                
                File.WriteAllText(cd + "\\firmware\\idData.txt", idData.Text.ToString());
                _spManager.StopListening();
                //clear any exisitng test data
                initializeForTest();
            }
            if (versiontime == 1)
            {
                _spManager.SendString("VERSION");
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
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void btnClearList_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cd + "\\firmware\\idData.txt", String.Empty);
            idData.Clear();
            // set focus
            this.ActiveControl = txtDeviceID;
        }

        private void btnWebRefresh_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            MemoryStream memoryStream = new MemoryStream();
            using (Stream input = client.OpenRead("https://sf.fatmongoose.com/sf/pwc/"))
            {
                input.CopyTo(memoryStream);
            }
            memoryStream.Position = 0;

            StreamReader reader = new StreamReader(memoryStream);
            _testdata.content = reader.ReadToEnd();
            reader.BaseStream.Position = 0;
            
            this.ActiveControl = btnLoadFW;
        }

        private void btn_ShowFile_Click(object sender, EventArgs e)
        {
            
            string filePath = cd + "\\firmware\\idData.txt";
            if (!File.Exists(filePath))
            {
                return;
            }

            // combine the arguments together
            // it doesn't matter if there is a space after ','
            string argument = "/select, \"" + filePath + "\"";

            Process.Start("explorer.exe", argument);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //initializeForTest();
            nameCollect();

            groupBox2.BringToFront();
            groupBox1.SendToBack();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nameCollect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            whitelistCollect();
            makeListFile();
            MkSpiffs();

            groupBox2.SendToBack();
            groupBox1.BringToFront();
            this.ActiveControl = txtDeviceID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makeListFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MkSpiffs();
        }
    }
}


