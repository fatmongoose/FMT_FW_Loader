using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Reflection;
using System.ComponentModel;
using System.Threading;
using System.IO;

namespace FMT_FW_Loader.Serial
{
    /// <summary>
    /// Manager for serial port data
    /// </summary>
    public class SerialPortManager : IDisposable
    {
        public SerialPortManager()
        {
            // Finding installed serial ports on hardware
            //_currentSerialSettings.PortNameCollection = SerialPort.GetPortNames();
            //_currentSerialSettings.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(_currentSerialSettings_PropertyChanged);

            refreshPorts();

        }

        
        ~SerialPortManager()
        {
            Dispose(false);
        }


        #region Fields
        private SerialPort _serialPort;
        private SerialSettings _currentSerialSettings = new SerialSettings();
        private string _latestRecieved = String.Empty;
        public event EventHandler<SerialDataEventArgs> NewSerialDataRecieved;

        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the current serial port settings
        /// </summary>
        public SerialSettings CurrentSerialSettings
        {
            get { return _currentSerialSettings; }
            set { _currentSerialSettings = value; }
        }

        #endregion

        #region Event handlers



        void _currentSerialSettings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // if serial port is changed, a new baud query is issued
           // if (e.PropertyName.Equals("PortName"))
               // UpdateBaudRateCollection();
        }

        
        //void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
//            int datalength = _serialPort.BytesToRead;
 //           byte[] data = new byte[datalength];
  //          int nbrDataRead = _serialPort.Read(data, 0, datalength);
          //  string serialLine = _serialPort.ReadLine();
            // byte[] data = Encoding.ASCII.GetBytes(serialLine);
            // int nbrDataRead = data.Length;

            //            if (nbrDataRead == 0)
          //  if (serialLine.Length == 0)
          //      return;
            // Send data to whom ever interested
           // NewSerialDataRecieved?.Invoke(this, new SerialDataEventArgs(serialLine));
            //NewSerialDataRecieved(this, new SerialDataEventArgs(data,serialLine));
       // }

        void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
            string serialLine = _serialPort.ReadLine();
            // Send data to whom ever interested
            NewSerialDataRecieved?.Invoke(this, new SerialDataEventArgs(serialLine));

        }
        catch (Exception)
            {
                //NewSerialDataRecieved?.Invoke(this, new SerialDataEventArgs("WTF MATE?"));
            }
            timer1.Start();
        }



        #endregion

        #region Methods
        /// <summary>
        /// Send a line of txt via serial port defined through the current settings
        /// </summary>
        public void SendString(string str)
        {
            if (_serialPort.IsOpen == false)
            {
                _serialPort.Open();
            }
            _serialPort.WriteLine(str);
        }

        public void refreshPorts()
        {
            // Finding installed serial ports on hardware
            _currentSerialSettings.PortNameCollection = SerialPort.GetPortNames();
            _currentSerialSettings.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(_currentSerialSettings_PropertyChanged);

            //SerialPortService.PortsChanged += (sender1, changedArgs) => DoSomethingSerial(changedArgs.SerialPorts);

            // If serial ports are found, we select the first found
            if (_currentSerialSettings.PortNameCollection.Length > 0)
                _currentSerialSettings.PortName = _currentSerialSettings.PortNameCollection[0];
            else
            {
                _currentSerialSettings.PortNameCollection = (null);
                _currentSerialSettings.PortName = null;
            }
        }



        /// <summary>
        /// Connects to a serial port defined through the current settings
        /// </summary>
        public void StartListening()
        {
            // Closing serial port if it is open
            if (_serialPort != null && _serialPort.IsOpen)
                    _serialPort.Close();

            // Setting serial port settings
            _serialPort = new SerialPort(
                _currentSerialSettings.PortName,
                _currentSerialSettings.BaudRate,
                _currentSerialSettings.Parity,
                _currentSerialSettings.DataBits,
                _currentSerialSettings.StopBits);

            // _serialPort.ReadTimeout = 100;
            // _serialPort.NewLine = "\r\n";

            _serialPort.ReadTimeout = 75;

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100;

//            timer1.Tick += timer1_Tick;
            timer1.Start();


            // Subscribe to event and open serial port for data
//            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
            _serialPort.Open();
            
        }

        /// <summary>
        /// Closes the serial port
        /// </summary>
        public void StopListening()
        {
           if (_serialPort != null)
           {
                timer1.Stop();
                _serialPort.Close();
 
            }
        }


        /// <summary>
        /// Retrieves the current selected device's COMMPROP structure, and extracts the dwSettableBaud property
        /// </summary>
        private void UpdateBaudRateCollection()
        {
            _serialPort = new SerialPort(_currentSerialSettings.PortName);
            _serialPort.Open();
            object p = _serialPort.BaseStream.GetType().GetField("commProp", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_serialPort.BaseStream);
            Int32 dwSettableBaud = (Int32)p.GetType().GetField("dwSettableBaud", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).GetValue(p);

            _serialPort.Close();
            _currentSerialSettings.UpdateBaudRateCollection(dwSettableBaud);
        }

        // Call to release serial port
        public void Dispose()
        {
            Dispose(true);
        }

        // Part of basic design pattern for implementing Dispose
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
          {
             //   _serialPort.DataReceived -= new SerialDataReceivedEventHandler(_serialPort_DataReceived);
            }
            // Releasing serial port (and other unmanaged objects)
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();

                _serialPort.Dispose();
            }
        }


        #endregion

    }

    /// <summary>
    /// EventArgs used to send bytes recieved on serial port
    /// </summary>
    public class SerialDataEventArgs : EventArgs
    {
        //public SerialDataEventArgs(byte[] dataInByteArray)
        //{
        //    Data = dataInByteArray;
        //}
//        public SerialDataEventArgs(byte[] dataInByteArray, string serialLine)
        public SerialDataEventArgs(string serialLine)
        {
            //    Data = dataInByteArray;
            Str = serialLine;
        }

        /// <summary>
        /// Byte array containing data from serial port
        /// </summary>
        //public byte[] Data;
        public string Str;
    }
}
