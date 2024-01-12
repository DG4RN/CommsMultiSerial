using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCommsMultiSerial
{
    public partial class Form1 : Form    // Form1 abgeleitet von der Basis Form
    {
        SerialPort ComPortRig1 = new SerialPort();
        SerialPort ComPortRig2 = new SerialPort();
        SerialPort SerialPort3 = new SerialPort();

        

        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);

        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);

        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;

        delegate void SetTextCallback(string text);
        
        int InputData, Inputdatanumber, InputData3, Inputdatanumber3;
        byte[] TS2000 = new byte[50];
        char[] bufferTS = new char[12];
        byte[] ldmospa = new byte[500];

        string counter;
        string counter3;
        
        string InputData2nd = String.Empty;
        string actualFrequence = String.Empty;
        string frequence = String.Empty;
        

        




        public Form1()
        {
            InitializeComponent();
            SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            ComPortRig1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            ComPortRig2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_2);
            SerialPort3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_3);
            SerialPort3.PortName = "COM12";
            SerialPort3.BaudRate = 4800;
            SerialPort3.DataBits = 8;
            SerialPort3.Encoding = Encoding.UTF8;
            SerialPort3.Open();
           
            
        }

        #region 1st COM PORT
        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            //Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);
            } while (!((ArrayComPortsNames[index] == ComPortName) ||
              (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            //get first item print in text
            cboPorts.Text = ArrayComPortsNames[0];

            //Baud Rate
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(4800);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600);
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();

            //get first item print in text
            cboBaudRate.Text = cboBaudRate.Items[5].ToString();

            //Data Bits
            cboDataBits.Items.Add(7);
            cboDataBits.Items.Add(8);
            //get the first item print it in the text 
            cboDataBits.Text = cboDataBits.Items[1].ToString();

            //Stop Bits
            cboStopBits.Items.Add("One");
            cboStopBits.Items.Add("OnePointFive");
            cboStopBits.Items.Add("Two");
            //get the first item print in the text
            cboStopBits.Text = cboStopBits.Items[0].ToString();

            //Parity 
            cboParity.Items.Add("None");
            cboParity.Items.Add("Even");
            cboParity.Items.Add("Mark");
            cboParity.Items.Add("Odd");
            cboParity.Items.Add("Space");

            //get the first item print in the text

            cboParity.Text = cboParity.Items[0].ToString();

            //Handshake
            cboHandShaking.Items.Add("None");
            cboHandShaking.Items.Add("XOnXOff");
            cboHandShaking.Items.Add("RequestToSend");
            cboHandShaking.Items.Add("RequestToSendXOnXOff");

            //get the first item print it in the text 
            cboHandShaking.Text = cboHandShaking.Items[0].ToString();

        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            Inputdatanumber = ComPortRig1.BytesToRead;
            counter = Convert.ToString(Inputdatanumber);

            InputData = ComPortRig1.Read(TS2000, 0, Inputdatanumber);
            
            Thread.Sleep(500);
            int i = 0;
            while(InputData >i && InputData > 13)
            {
                if ((TS2000[i] == 0x46) && (TS2000[i+13] == 0x3b))
                {
                    int n = 0;
                    while(n<11)
                    {
                        bufferTS[n] = (char)TS2000[i+2+n];
                        n++;
                    }
                    frequence = new string(bufferTS);
                    

                    this.BeginInvoke(new SetTextCallback(SetText), new object[] { frequence });
                     this.BeginInvoke(new SetTextCallback(SetTextlbl), new object[] { counter });
                    this.BeginInvoke(new SetTextCallback(SetText), new object[] { "/ " });
                    ComPortRig1.DiscardInBuffer();
                    
                    break;
                }
                i++;
            }
        }

        private void SetText(string text)
        {
            this.rtbIncomingData.Text += text;
        }

        internal void PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            SerialPinChange SerialPinChange1 = 0;
            bool signalState = false;
            SerialPinChange1 = e.EventType;
            lblCTSStatus.BackColor = Color.Green;
            lblDSRStatus.BackColor = Color.Green;
            lblRIStatus.BackColor = Color.Green;
            lblBreakStatus.BackColor = Color.Green;

            switch (SerialPinChange1)
            {
                case SerialPinChange.Break:
                    lblBreakStatus.BackColor = Color.Red;
                    //MessageBox.Show("Break is Set");
                    break;
                case SerialPinChange.CDChanged:
                    signalState = ComPortRig1.CtsHolding;
                    //MessageBox.Show("CD = " + signalState.ToString());
                    break;
                case SerialPinChange.CtsChanged:
                    signalState = ComPortRig1.CDHolding;
                    lblCTSStatus.BackColor = Color.Red;
                    //MessageBox.Show("CTS = " + signalState.ToString());
                    break;
                case SerialPinChange.DsrChanged:
                    signalState = ComPortRig1.DsrHolding;
                    lblDSRStatus.BackColor = Color.Red;
                    // MessageBox.Show("DSR = " + signalState.ToString());
                    break;
                case SerialPinChange.Ring:
                    lblRIStatus.BackColor = Color.Red;
                    //MessageBox.Show("Ring Detected");
                    break;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
          /* SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            ComPort.PinChanged += SerialPinChangedEventHandler1;
            ComPort.Open();
            ComPort.RtsEnable = true;
            ComPort.DtrEnable = true;
            btnTest.Enabled = false; */
        }

        private void btnPortState_Click(object sender, EventArgs e)
        {
            if (btnPortState.Text == "Closed")
            {
                btnPortState.Text = "Open";
                btnPortState.BackColor = Color.Lime;
                ComPortRig1.PortName = Convert.ToString(cboPorts.Text);
                ComPortRig1.BaudRate = Convert.ToInt32(cboBaudRate.Text);
                ComPortRig1.DataBits = Convert.ToInt16(cboDataBits.Text);
                ComPortRig1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                ComPortRig1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                ComPortRig1.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
                ComPortRig1.Open();
            }
            else if (btnPortState.Text == "Open")
            {
                btnPortState.Text = "Closed";
                btnPortState.BackColor = Color.White;
                ComPortRig1.Close();
            }
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            ComPortRig1.Write("Hello World!");
        }

        private void rtbOutgoing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter key  
            {
                ComPortRig1.Write("\r\n");
                rtbOutgoing.Text = "";
            }
            else if (e.KeyChar < 32 || e.KeyChar > 126)
            {
                e.Handled = true; // ignores anything else outside printable ASCII range
            }
            else
            {
                ComPortRig1.Write(e.KeyChar.ToString());
            }
        }

        



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ComPortRig1.IsOpen)
            {
                ComPortRig1.Write("FA;");
                ComPortRig1.DiscardOutBuffer();
                rtbOutgoing.Text += "FA;";
            }
        }

        private void SetTextlbl(string text)
        {
            this.lblDatalength.Text = text;
        }

        private void rtbIncomingData_TextChanged(object sender, EventArgs e)
        {       // set the current caret position to the end
            rtbIncomingData.SelectionStart = rtbIncomingData.Text.Length;
            // scroll it automatically
            rtbIncomingData.ScrollToCaret();
        }

        private void rtbOutgoing_TextChanged(object sender, EventArgs e)
        {
            rtbOutgoing.SelectionStart = rtbOutgoing.Text.Length;
            // scroll it automatically
            rtbOutgoing.ScrollToCaret();
        }


        #endregion 1st COM PORT
 
        #region 2nd COM PORT
        private void btn2ndGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            //Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cbo2ndPort.Items.Add(ArrayComPortsNames[index]);
            } while (!((ArrayComPortsNames[index] == ComPortName) ||
              (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            //get first item print in text
            cbo2ndPort.Text = ArrayComPortsNames[0];

            //Baud Rate
            cbo2ndBaudRate.Items.Add(300);
            cbo2ndBaudRate.Items.Add(600);
            cbo2ndBaudRate.Items.Add(1200);
            cbo2ndBaudRate.Items.Add(2400);
            cbo2ndBaudRate.Items.Add(4800);
            cbo2ndBaudRate.Items.Add(9600);
            cbo2ndBaudRate.Items.Add(14400);
            cbo2ndBaudRate.Items.Add(19200);
            cbo2ndBaudRate.Items.Add(38400);
            cbo2ndBaudRate.Items.Add(57600);
            cbo2ndBaudRate.Items.Add(115200);
            cbo2ndBaudRate.Items.ToString();

            //get first item print in text
            cbo2ndBaudRate.Text = cbo2ndBaudRate.Items[7].ToString();

            //Data Bits
            cbo2ndDataBits.Items.Add(7);
            cbo2ndDataBits.Items.Add(8);
            //get the first item print it in the text 
            cbo2ndDataBits.Text = cbo2ndDataBits.Items[1].ToString();

            //Stop Bits
            cbo2ndStopBits.Items.Add("One");
            cbo2ndStopBits.Items.Add("OnePointFive");
            cbo2ndStopBits.Items.Add("Two");
            //get the first item print in the text
            cbo2ndStopBits.Text = cbo2ndStopBits.Items[0].ToString();

            //Parity 
            cbo2ndParity.Items.Add("None");
            cbo2ndParity.Items.Add("Even");
            cbo2ndParity.Items.Add("Mark");
            cbo2ndParity.Items.Add("Odd");
            cbo2ndParity.Items.Add("Space");

            //get the first item print in the text

            cbo2ndParity.Text = cbo2ndParity.Items[0].ToString();

            //Handshake
            cbo2ndHandShaking.Items.Add("None");
            cbo2ndHandShaking.Items.Add("XOnXOff");
            cbo2ndHandShaking.Items.Add("RequestToSend");
            cbo2ndHandShaking.Items.Add("RequestToSendXOnXOff");

            //get the first item print it in the text 
            cbo2ndHandShaking.Text = cbo2ndHandShaking.Items[0].ToString();

        }

        private void port_DataReceived_2(object sender, SerialDataReceivedEventArgs e)
        {
            InputData2nd = ComPortRig2.ReadExisting();
            if (InputData2nd != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText2nd), new object[] { InputData2nd });
                Thread.Sleep(500);
                ComPortRig2.DiscardInBuffer();
            }
        }

        private void SetText2nd(string text)
        {
            this.rtb2ndIncomingData.Text += text;
        }


        private void SetTextrtb2ndOutgoing(string text)
        {
            this.rtb2ndOutgoing.Text += text;
        }
        private void btn2ndPortState_Click(object sender, EventArgs e)
        {
            if (btn2ndPortState.Text == "Closed")
            {
                btn2ndPortState.Text = "Open";
                btn2ndPortState.BackColor = Color.Lime;
                ComPortRig2.PortName = Convert.ToString(cbo2ndPort.Text);
                ComPortRig2.BaudRate = Convert.ToInt32(cbo2ndBaudRate.Text);
                ComPortRig2.DataBits = Convert.ToInt16(cbo2ndDataBits.Text);
                ComPortRig2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbo2ndStopBits.Text);
                ComPortRig2.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cbo2ndHandShaking.Text);
                ComPortRig2.Parity = (Parity)Enum.Parse(typeof(Parity), cbo2ndParity.Text);
                ComPortRig2.Open();
            }
            else if (btn2ndPortState.Text == "Open")
            {
                btn2ndPortState.Text = "Closed";
                btn2ndPortState.BackColor = Color.White;
                ComPortRig2.Close();
            }
        }

        private void btn2ndHello_Click(object sender, EventArgs e)
        {
            ComPortRig2.Write("Hello World 2!");
        }

        private void rtb2ndOutgoing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter key  
            {
                ComPortRig2.Write("\r\n");
                rtb2ndOutgoing.Text = "";
            }
            else if (e.KeyChar < 32 || e.KeyChar > 126)
            {
                e.Handled = true; // ignores anything else outside printable ASCII range
            }
            else
            {
                ComPortRig2.Write(e.KeyChar.ToString());
            }
        }

       


        
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ComPortRig2.IsOpen && (frequence.Length == 12))
            {
                ComPortRig2.Write(frequence);
                ComPortRig2.DiscardOutBuffer();
                this.BeginInvoke(new SetTextCallback(SetTextrtb2ndOutgoing), new object[] { frequence });
                this.BeginInvoke(new SetTextCallback(SetTextrtb2ndOutgoing), new object[] { "/ " });
            }
        }


        private void rtb2ndOutgoing_TextChanged(object sender, EventArgs e)
        {
            rtb2ndOutgoing.SelectionStart = rtb2ndOutgoing.Text.Length;
            // scroll it automatically
            rtb2ndOutgoing.ScrollToCaret();
        }



        #endregion 2nd COM PORT


        static string ByteToHexBit(byte[] bytes)
        {
            char[] c = new char[bytes.Length * 2];
            int b;
            int d = (bytes.Length)-1;
            if (bytes[0] >= 10)
            {
                for (int i = 0; i < d; i++)
                {
                    b = bytes[i] / 10;
                    b = b * 16;
                    b = b + (bytes[i] - (bytes[i] / 10 * 10));
                    c[i] = Convert.ToChar(b);
                }
            }
            else if (bytes[0] <10)
            {
                b = bytes[0];
                c[0] = Convert.ToChar(b);
            }
            return new string(c);
        }



        static byte[] ConvertToBCD(int value)
        {
            string decimalString = value.ToString();
            if(decimalString.Length == 7)
            {
                decimalString = "0" + decimalString;
            }

            int numDigits = decimalString.Length;
            
            // Each digit is represented by 4 bits, so we need half the number of digits for bytes
            int numBytes = (int)Math.Ceiling(numDigits / 2.0);

            byte[] bcdBytes = new byte[numBytes];

            for (int i = 0; i < numDigits; i++)
            {
                int digit = decimalString[i] - '0';

                // If the current position is even, the digit occupies the lower 4 bits
                if (i % 2 == 0)
                {
                    bcdBytes[i / 2] |= (byte)(digit & 0x0F);
                }
                // If the current position is odd, the digit occupies the upper 4 bits
                else
                {
                    bcdBytes[i / 2] |= (byte)((digit & 0x0F) << 4);
                }
            }

            return bcdBytes;
        }

        static byte SwapNibbles(byte value)
        {
            // Mask and shift to extract high and low nibbles
            byte highNibble = (byte)((value & 0xF0) >> 4);
            byte lowNibble = (byte)(value & 0x0F);

            // Swap and combine nibbles
            return (byte)((lowNibble << 4) | highNibble);
        }


        static byte[] PaFrequenz( string frequence)
        {
            int frequency = Convert.ToInt32(frequence);
                        
            byte[] bcdBytes = ConvertToBCD(frequency);
                     
            var SendBuffer = new byte[10];


            SendBuffer[0] = 254;
            SendBuffer[1] = 254;
            SendBuffer[2] = 224;
            SendBuffer[3] = 00;
            SendBuffer[4] = 03;

            SendBuffer[8] = SwapNibbles(bcdBytes[0]);
            SendBuffer[7] = SwapNibbles(bcdBytes[1]);
            SendBuffer[6] = SwapNibbles(bcdBytes[2]);
            SendBuffer[5] = SwapNibbles(bcdBytes[3]);
      

            SendBuffer[9] = 253;

            return SendBuffer;
        }
       

        private void SetText3rd(string text)
        {
            this.rtbPort3RXBox.Text += text;
            
        }

        private void rtbPort3RXBox_TextChanged(object sender, EventArgs e)
        {
            rtbPort3RXBox.SelectionStart = rtbPort3RXBox.Text.Length;
            // scroll it automatically
            rtbPort3RXBox.ScrollToCaret();
        }

        private void SetTextlbl3(string text)
        {
            this.lblFrequenzPA.Text = text;
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ComPortRig1.IsOpen && ComPortRig2.IsOpen && (frequence.Length > 0))
            {
                /*byte[] bytes = PaFrequenz(frequence);
                
                SerialPort3.Write(bytes, 0, bytes.Length);
                SerialPort3.DiscardOutBuffer();
                */
                this.BeginInvoke(new SetTextCallback(SetText3rd), new object[] { frequence });
                this.BeginInvoke(new SetTextCallback(SetText3rd), new object[] { "/ " });

                

            }
        }

        private void port_DataReceived_3(object sender, SerialDataReceivedEventArgs e)
        {
            if (ComPortRig1.IsOpen && ComPortRig2.IsOpen && (frequence.Length > 0))
            {
                Inputdatanumber3 = SerialPort3.BytesToRead;
                counter3 = Convert.ToString(Inputdatanumber3);

                InputData3 = SerialPort3.Read(ldmospa, 0, Inputdatanumber3);


                Thread.Sleep(200);
                int i = 0;
                while (InputData3 > i && InputData3 > 4)
                {
                    if ((ldmospa[i] == 0xfe) && (ldmospa[i + 1] == 0xfe))
                    {
                        byte[] bytes = PaFrequenz(frequence);

                        SerialPort3.Write(bytes, 0, bytes.Length);
                        SerialPort3.DiscardOutBuffer();

                        this.BeginInvoke(new SetTextCallback(SetTextlbl3), new object[] { counter3 });
                        SerialPort3.DiscardInBuffer();

                        break;
                    }
                    i++;
                }
            }
        }


    }



}
