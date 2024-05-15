using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace ControlLed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOpen.Enabled = true;
            buttonClose.Enabled = false;
            buttonLedOn.Enabled = false;
            buttonLedOff.Enabled = false;
            comboBoxBaudRate.Text = "9600";
            progressBarConnection.Value = 0;
            pin3.Image = Properties.Resources.green_led_off_md;

            string[] portList = SerialPort.GetPortNames();
            comboBoxComPort.Items.AddRange(portList);
            //comboBoxComPort.SelectedItem = portList[0];  // care with this may throw an exception if no items on the array
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort1.Open();

                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                buttonLedOn.Enabled = true;
                buttonLedOff.Enabled = true;
                progressBarConnection.Value = 100;
                comboBoxBaudRate.Enabled = false;
                comboBoxComPort.Enabled = false;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    // firt turn off led if it is on
                    serialPort1.WriteLine("#Off");
                    pin3.Image = Properties.Resources.green_led_off_md;

                    serialPort1.Close();

                    buttonOpen.Enabled = true;
                    buttonClose.Enabled = false;
                    buttonLedOn.Enabled = false;
                    buttonLedOff.Enabled = false;
                    progressBarConnection.Value = 0;
                    comboBoxBaudRate.Enabled = true;
                    comboBoxComPort.Enabled = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonLedOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    // change the picture to led on
                    pin3.Image = Properties.Resources.green_led_on_md;

                    // send command to arduino to turn on led
                    serialPort1.WriteLine("#On");
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            
        }

        private void buttonLedOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    pin1.Image = Properties.Resources.green_led_off_md;
                    pin2.Image = Properties.Resources.green_led_off_md;
                    pin3.Image = Properties.Resources.green_led_off_md;
                    pin4.Image = Properties.Resources.green_led_off_md;
                    pin5.Image = Properties.Resources.green_led_off_md;
                    pin6.Image = Properties.Resources.green_led_off_md;

                    // send command to arduino to turn off the led.
                    serialPort1.WriteLine("#Off");
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    // firt turn off led if it is on
                    serialPort1.WriteLine("#Off");
                    pin3.Image = Properties.Resources.green_led_off_md;

                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                string serialData = serialPort1.ReadLine();

                //  int value = Convert.ToInt32(serialData);

                //***************************************************************************************

                if (serialData.Contains("#C10"))
                {
                    conector.Image = Properties.Resources._10pinfemale;
                }
                if (serialData.Contains("#C6"))
                {
                    conector.Image = Properties.Resources._6pinfull1;
                }

               // else serialData.Contains("#C0");
               // {
               //     conector.Image = Properties.Resources.green_led_off_md;
               // }

                //***************************************************************************************

                if (serialData.Contains("PIN1#OK"))
                {
                    pin1.Image = Properties.Resources.green_led_on_md;
                }

                if (serialData.Contains("PIN1#OK"))
                {
                    pin1.Image = Properties.Resources.green_led_on_md;
                }
                //else { pin8.Image=Properties.Resources.green_led_off_md; }
                
                if (serialData.Contains("PIN2#OK"))
                {
                    pin2.Image = Properties.Resources.green_led_on_md;
                }
                //else { pin8.Image=Properties.Resources.green_led_off_md; }
                if (serialData.Contains("PIN3#OK"))
                {
                    pin3.Image = Properties.Resources.green_led_on_md;
                }
                //else { pin8.Image=Properties.Resources.green_led_off_md; }
                if (serialData.Contains("PIN4#OK"))
                {
                    pin4.Image = Properties.Resources.green_led_on_md;
                }
                //else { pin8.Image=Properties.Resources.green_led_off_md; }
                if (serialData.Contains("PIN5#OK"))
                {
                    pin5.Image = Properties.Resources.green_led_on_md;
                }
                //else { pin8.Image=Properties.Resources.green_led_off_md; }
                if (serialData.Contains("PIN6#OK"))
                {
                    pin6.Image = Properties.Resources.green_led_on_md;
                }
                //else { pin8.Image=Properties.Resources.green_led_off_md; }


            }
        }
    }
}
