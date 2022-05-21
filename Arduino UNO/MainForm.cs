using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_UNO
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Команда на включение и установку цвета
        /// </summary>
        const byte TURN_ON_COMMAND = 1;

        /// <summary>
        /// Команда на выключение
        /// </summary>
        const byte TURN_OFF_COMMAND = 0;

        /// <summary>
        /// Состояние подключения к Arduino
        ///     true - подключено
        ///     false - отподключено
        /// </summary>
        bool isConnected = false;
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Установить состояние визаульных контролов в зависимости состояния подключения
        /// </summary>
        private void SetControlsState()
        {
            ViewColor.Enabled = isConnected;
            ButtonUpload.Enabled = isConnected;
            ButtonOff.Enabled = isConnected;
            ButtonConnect.Text = isConnected ? "Отключение" : "Подключение";
        }

        private void connectToArduino()
        {
            try
            {
                string selectedPort = ViewPorts.GetItemText(ViewPorts.SelectedItem);
                serialPort.PortName = selectedPort;
                serialPort.Open();
                ButtonConnect.BackColor = System.Drawing.Color.SpringGreen;
                isConnected = true;
                SetControlsState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Ошибка подключения: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void disconnectFromArduino()
        {
            if (!isConnected) return;

            isConnected = false;
            serialPort.Close();
            ButtonConnect.BackColor = System.Drawing.Color.Red;

            SetControlsState();
        }

        private void PortSelection_Click(object sender, EventArgs e)
        {
            ViewPorts.Items.Clear();
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length == 0)
            {
                MessageBox.Show(this, "Нет доступных COM портов.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (string portName in portnames)
            {
                ViewPorts.Items.Add(portName);
                if (portnames[0] != null)
                {
                    ViewPorts.SelectedItem = portnames[0];
                }
            }
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            var dialogResult = colorDialog.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                MessageBox.Show(this, "Цвет не был выбран.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                ViewColor.BackColor = colorDialog.Color;


            var arr = new byte[] { TURN_ON_COMMAND, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B };

            if (isConnected)
            {
                serialPort.Write(arr, 0, arr.Length);
            }
        }
        private void ButtonOff_Click(object sender, EventArgs e)
        {
            ViewColor.BackColor = System.Drawing.Color.White;
            serialPort.Write(new byte[] { TURN_OFF_COMMAND }, 0, 1);
        }

    }
}
