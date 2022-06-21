namespace Проверка_полтов
{
    partial class TestPort1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPort1));
            this.AdresLabel = new System.Windows.Forms.Label();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portpk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AdresLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdresLabel.Location = new System.Drawing.Point(10, 15);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(164, 26);
            this.AdresLabel.TabIndex = 0;
            this.AdresLabel.Text = "Введите адрес";
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AdresTextBox.Location = new System.Drawing.Point(180, 12);
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(262, 32);
            this.AdresTextBox.TabIndex = 1;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PortLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PortLabel.Location = new System.Drawing.Point(10, 67);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(150, 26);
            this.PortLabel.TabIndex = 0;
            this.PortLabel.Text = "Введите порт";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PortTextBox.Location = new System.Drawing.Point(180, 64);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(262, 32);
            this.PortTextBox.TabIndex = 1;
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.connect.Location = new System.Drawing.Point(448, 18);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(185, 60);
            this.connect.TabIndex = 2;
            this.connect.Text = "Проверка";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-14, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "/////////////////////////////////////////////////////////////////////////////////" +
    "////////////////////////////////////////////////////";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите адрес";
            // 
            // ipp
            // 
            this.ipp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ipp.Location = new System.Drawing.Point(182, 175);
            this.ipp.Name = "ipp";
            this.ipp.Size = new System.Drawing.Size(262, 32);
            this.ipp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(10, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите начальный порт";
            // 
            // portps
            // 
            this.portps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.portps.Location = new System.Drawing.Point(285, 248);
            this.portps.Name = "portps";
            this.portps.Size = new System.Drawing.Size(262, 32);
            this.portps.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(10, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите конечный порт";
            // 
            // portpk
            // 
            this.portpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.portpk.Location = new System.Drawing.Point(285, 297);
            this.portpk.Name = "portpk";
            this.portpk.Size = new System.Drawing.Size(262, 32);
            this.portpk.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(223, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestPort1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(641, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.portpk);
            this.Controls.Add(this.portps);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.ipp);
            this.Controls.Add(this.AdresTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdresLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestPort1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка портов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdresLabel;
        private System.Windows.Forms.TextBox AdresTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox portpk;
        private System.Windows.Forms.Button button1;
    }
}

