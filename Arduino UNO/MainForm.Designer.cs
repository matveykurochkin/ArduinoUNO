namespace Arduino_UNO
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ViewPorts = new System.Windows.Forms.ComboBox();
            this.PortSelection = new System.Windows.Forms.Button();
            this.ButtonUpload = new System.Windows.Forms.Button();
            this.ButtonOff = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ViewColor = new System.Windows.Forms.TextBox();
            this.InfoColorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ButtonConnect.Location = new System.Drawing.Point(15, 71);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(200, 29);
            this.ButtonConnect.TabIndex = 6;
            this.ButtonConnect.Text = "Подключение";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ViewPorts
            // 
            this.ViewPorts.FormattingEnabled = true;
            this.ViewPorts.Location = new System.Drawing.Point(15, 41);
            this.ViewPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewPorts.Name = "ViewPorts";
            this.ViewPorts.Size = new System.Drawing.Size(199, 27);
            this.ViewPorts.TabIndex = 7;
            // 
            // PortSelection
            // 
            this.PortSelection.Location = new System.Drawing.Point(14, 8);
            this.PortSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PortSelection.Name = "PortSelection";
            this.PortSelection.Size = new System.Drawing.Size(201, 29);
            this.PortSelection.TabIndex = 9;
            this.PortSelection.Text = "Выбор порта";
            this.PortSelection.UseVisualStyleBackColor = true;
            this.PortSelection.Click += new System.EventHandler(this.PortSelection_Click);
            // 
            // ButtonUpload
            // 
            this.ButtonUpload.Enabled = false;
            this.ButtonUpload.Location = new System.Drawing.Point(14, 192);
            this.ButtonUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonUpload.Name = "ButtonUpload";
            this.ButtonUpload.Size = new System.Drawing.Size(201, 29);
            this.ButtonUpload.TabIndex = 10;
            this.ButtonUpload.Text = "Выбор цвета";
            this.ButtonUpload.UseVisualStyleBackColor = true;
            this.ButtonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // ButtonOff
            // 
            this.ButtonOff.Enabled = false;
            this.ButtonOff.Location = new System.Drawing.Point(14, 225);
            this.ButtonOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOff.Name = "ButtonOff";
            this.ButtonOff.Size = new System.Drawing.Size(201, 29);
            this.ButtonOff.TabIndex = 11;
            this.ButtonOff.Text = "Выключить ";
            this.ButtonOff.UseVisualStyleBackColor = true;
            this.ButtonOff.Click += new System.EventHandler(this.ButtonOff_Click);
            // 
            // ViewColor
            // 
            this.ViewColor.Enabled = false;
            this.ViewColor.Location = new System.Drawing.Point(15, 125);
            this.ViewColor.Multiline = true;
            this.ViewColor.Name = "ViewColor";
            this.ViewColor.Size = new System.Drawing.Size(200, 62);
            this.ViewColor.TabIndex = 12;
            // 
            // InfoColorLabel
            // 
            this.InfoColorLabel.AutoSize = true;
            this.InfoColorLabel.Location = new System.Drawing.Point(55, 103);
            this.InfoColorLabel.Name = "InfoColorLabel";
            this.InfoColorLabel.Size = new System.Drawing.Size(118, 19);
            this.InfoColorLabel.TabIndex = 13;
            this.InfoColorLabel.Text = "Просмотр цвета";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 265);
            this.Controls.Add(this.InfoColorLabel);
            this.Controls.Add(this.ViewColor);
            this.Controls.Add(this.ButtonOff);
            this.Controls.Add(this.ButtonUpload);
            this.Controls.Add(this.PortSelection);
            this.Controls.Add(this.ViewPorts);
            this.Controls.Add(this.ButtonConnect);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ArduinoUNO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.ComboBox ViewPorts;
        private System.Windows.Forms.Button PortSelection;
        private System.Windows.Forms.Button ButtonUpload;
        private System.Windows.Forms.Button ButtonOff;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox ViewColor;
        private System.Windows.Forms.Label InfoColorLabel;
    }
}

