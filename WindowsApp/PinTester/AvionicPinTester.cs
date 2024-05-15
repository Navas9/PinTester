using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml;
using System.Drawing;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            botonConectar.Enabled = true;
            botonDesconectar.Enabled = false;
            inicioTest.Enabled = false;
            reset.Enabled = false;
            comboBoxBaudRate.Text = "9600";
            progressBarConnection.Value = 0;
            pin3.Image = PinTester.Properties.Resources.green_led_off_md;

            string[] portList = SerialPort.GetPortNames();
            comboBoxComPort.Items.AddRange(portList);
        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort1.Open();

                botonConectar.Enabled = false;
                botonDesconectar.Enabled = true;
                inicioTest.Enabled = true;
                reset.Enabled = true;
                progressBarConnection.Value = 100;
                comboBoxBaudRate.Enabled = false;
                comboBoxComPort.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    //pin3.Image = PinTester.Properties.Resources.green_led_off_md;

                    serialPort1.Close();

                    botonConectar.Enabled = true;
                    botonDesconectar.Enabled = false;
                    inicioTest.Enabled = false;
                    reset.Enabled = false;
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

        private void inicioTest_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine("#On");
                   // inicioTest.Enabled = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void botonReset(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    //Conector 6p
                    pin1.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin2.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin3.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin4.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin5.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin6.Image = PinTester.Properties.Resources.green_led_off_md;

                    //Conector 10p

                    pin101.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin102.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin103.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin104.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin105.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin106.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin107.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin108.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin109.Image = PinTester.Properties.Resources.green_led_off_md;
                    pin1010.Image = PinTester.Properties.Resources.green_led_off_md;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            
        }

        private void autoReset()
        {
            botonReset(this, EventArgs.Empty);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        //*************************TEST
        private void Mostrar6pin()
        {
            if (pin101.InvokeRequired)
            {
                pin1.Invoke((MethodInvoker)delegate
                {
                    PinesConector.Image = PinTester.Properties.Resources._6p;
                    pin1.Visible = true;
                    pin2.Visible = true;
                    pin3.Visible = true;
                    pin4.Visible = true;
                    pin5.Visible = true;
                    pin6.Visible = true;
                });
            }
            else
            {
                PinesConector.Image = PinTester.Properties.Resources._6p;
                pin1.Visible = true;
                pin2.Visible = true;
                pin3.Visible = true;
                pin4.Visible = true;
                pin5.Visible = true;
                pin6.Visible = true;
            }
        }

        private void Mostrar10pin()
        {
            if (pin101.InvokeRequired)
            {
                pin101.Invoke((MethodInvoker)delegate
                {
                    PinesConector.Image = PinTester.Properties.Resources._10p;
                    pin101.Visible = true;
                    pin102.Visible = true;
                    pin103.Visible = true;
                    pin104.Visible = true;
                    pin105.Visible = true;
                    pin106.Visible = true;
                    pin107.Visible = true;
                    pin108.Visible = true;
                    pin109.Visible = true;
                    pin1010.Visible = true;
                });
            }
            else
            {
                PinesConector.Image = PinTester.Properties.Resources._10p;
                pin101.Visible = true;
                pin102.Visible = true;
                pin103.Visible = true;
                pin104.Visible = true;
                pin105.Visible = true;
                pin106.Visible = true;
                pin107.Visible = true;
                pin108.Visible = true;
                pin109.Visible = true;
                pin1010.Visible = true;
            }
        }

        private void Ocultar6pin()
        {
            if (pin1.InvokeRequired)
            {
                pin1.Invoke((MethodInvoker)delegate
                {
                    pin1.Visible = false;
                    pin2.Visible = false;
                    pin3.Visible = false;
                    pin4.Visible = false;
                    pin5.Visible = false;
                    pin6.Visible = false;
                });
            }
            else
            {
                pin1.Visible = false;
                pin2.Visible = false;
                pin3.Visible = false;
                pin4.Visible = false;
                pin5.Visible = false;
                pin6.Visible = false;
            }
        }

        private void Ocultar10pin()
        {
            if (pin101.InvokeRequired)
            {
                pin101.Invoke((MethodInvoker)delegate
                {
                    PinesConector.Image = PinTester.Properties.Resources._6p;
                    pin101.Visible = false;
                    pin102.Visible = false;
                    pin103.Visible = false;
                    pin104.Visible = false;
                    pin105.Visible = false;
                    pin106.Visible = false;
                    pin107.Visible = false;
                    pin108.Visible = false;
                    pin109.Visible = false;
                    pin1010.Visible = false;
                });
            }
            else
            {
                PinesConector.Image = PinTester.Properties.Resources._6p;
                pin101.Visible = false;
                pin102.Visible = false;
                pin103.Visible = false;
                pin104.Visible = false;
                pin105.Visible = false;
                pin106.Visible = false;
                pin107.Visible = false;
                pin108.Visible = false;
                pin109.Visible = false;
                pin1010.Visible = false;
            }
        }
        //*************************TEST

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                string serialData = serialPort1.ReadLine();

                //  int value = Convert.ToInt32(serialData);

                //***************************************************************************************

                if (serialData.Contains("#C10"))
                {
                    conector.Image = PinTester.Properties.Resources._10pinfemale;
                    if (resultados.Checked.Equals(false))
                    {
                        autoReset();
                    }
                    Ocultar6pin();
                    Mostrar10pin();
                }
                if (serialData.Contains("#C6"))
                {
                    if (resultados.Checked.Equals(false))
                    {
                        autoReset();
                    }
                    Ocultar10pin();
                    Mostrar6pin();
                    conector.Image = PinTester.Properties.Resources._6pinfull1;
                  //  pin101.Visible = false;
                  //  pin1.Visible = true;
                  //  pin2.Visible = true;
                  //  pin3.Visible = true;
                  //  pin4.Visible = true;
                  //  pin5.Visible = true;
                  //  pin6.Visible = true;
                }

               // else serialData.Contains("#C0");
               // {
               //     conector.Image = PinTester.Properties.Resources.green_led_off_md;
               // }

                //***************************************************************************************

                if (serialData.Contains("PIN1#OK"))
                {
                    pin1.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin101.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN1#KO"))
                {
                    pin1.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin101.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN2#OK"))
                {
                    pin2.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin102.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN2#KO"))
                {
                    pin2.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin102.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN3#OK"))
                {
                    pin3.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin103.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN3#KO"))
                {
                    pin3.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin103.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN4#OK"))
                {
                    pin4.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin104.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN4#KO"))
                {
                    pin4.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin104.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN5#OK"))
                {
                    pin5.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin105.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN5#KO"))
                {
                    pin5.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin105.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN6#OK"))
                {
                    pin6.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin106.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN6#KO"))
                {
                    pin6.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin106.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN7#OK"))
                {
                    pin107.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin107.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN7#KO"))
                {
                    pin107.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin107.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN8#OK"))
                {
                    pin108.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin108.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN8#KO"))
                {
                    pin108.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin108.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN9#OK"))
                {
                    pin109.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin109.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN9#KO"))
                {
                    pin109.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin109.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("PIN10#OK"))
                {
                    pin1010.Image = PinTester.Properties.Resources.green_led_on_md;
                    pin1010.Image = PinTester.Properties.Resources.green_led_on_md;
                }
                if (serialData.Contains("PIN10#KO"))
                {
                    pin1010.Image = PinTester.Properties.Resources.red_led_on_md;
                    pin1010.Image = PinTester.Properties.Resources.red_led_on_md;
                }
                if (serialData.Contains("#Off"))
                {
 //                   inicioTest.Enabled = true;  
                }
            }
        }
    }
}
