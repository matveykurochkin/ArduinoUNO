using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_UNO
{
    public partial class Form1 : Form
    {
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

        private void button3_Click(object sender, EventArgs e)
        {
          
            string red =  textBox1.Text;
            string green = textBox2.Text;
            string blue = textBox3.Text;
            string[] arr = new string[] {red,green,blue };
            if (isConnected)
            {
                serialPort1.WriteLine("1");
                for (int i = 0; i<3;i++)
                {
                    serialPort1.WriteLine(arr[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
        }

    }
}
