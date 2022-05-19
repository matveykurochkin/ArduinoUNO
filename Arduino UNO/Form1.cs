using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_UNO
{
    public partial class Form1 : Form
    {
        const byte TURN_ON_COMMAND = 1;
        const byte TURN_OFF_COMMAND = 0;

        bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            serialPort1.PortName = selectedPort;
            serialPort1.Open();
            button2.Text = "Отключить";
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            serialPort1.Close();
            button2.Text = "Подключено";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length == 0)
            {
                MessageBox.Show("COM PORT not found");
            }
            foreach (string portName in portnames)
            {
                comboBox1.Items.Add(portName);
                Console.WriteLine(portnames.Length);
                if (portnames[0] != null)
                {
                    comboBox1.SelectedItem = portnames[0];
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            if (!byte.TryParse(textBox1.Text, out var red))
            {
                MessageBox.Show("error");
                return;

            }
            if (!byte.TryParse(textBox2.Text, out var green))
            {
                MessageBox.Show("error");
                return;

            }
            if (!byte.TryParse(textBox3.Text, out var blue))
            {
                MessageBox.Show("error");
                return;

            }

            byte[] arr = new byte[] { TURN_ON_COMMAND, red, green, blue };

            if (isConnected)
            {
                serialPort1.Write(arr, 0, arr.Length);
            }
        }
        // ctrl + k + d
        private void ButtonOff_Click(object sender, EventArgs e)
        {
            serialPort1.Write(new byte[] { TURN_OFF_COMMAND },0,1);
        }

    }
}
