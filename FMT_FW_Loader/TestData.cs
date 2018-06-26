using System;
using System.IO;
using System.IO.Ports;

namespace TestData.TD
{

    public class TestDataRec
    {
        public int _testState = 0;  //0 means no test, 1 is progress, 2 is complete and ready for upload. 
        public string DeviceID = "00000000";// { get; set; }
        public string PAC = "0000000000000000";// { get; set; }
        public int v_bat = 0000;  //4.2v
        public int v_reg = 0000;  //3.3v
        public bool _button_state_0_detected = false;
        public int initBtnState = 1;
        public bool ButtonPressTest = false;

        public string TesterName = "John Doe"; // { get; set; }
        public string TestStandID = "1"; // { get; set; }
        public string BoardSN = "1111111111"; // { get; set; }

        public string _portName = "";
        public string[] _portNameCollection;
        public int _baudRate = 115200;
        public int _prog_baudRate = 921600;
        public Parity _parity = Parity.None;
        public int _dataBits = 8;
        public int[] _dataBitsCollection = new int[] { 5, 6, 7, 8 };
        public StopBits _stopBits = StopBits.One;
        public double noise_power = -140.0;
        public double noise_power_freq = 0.0;
        public bool RF_Test_pass = false;
        public double RF_Test_pwr = -140.0;
        public double RF_Test_pwr_freq = 0.0;
        public bool TestResult = false;
        public bool LedAudioTest = false;

        public string Text = "Test Log";
    }
}
