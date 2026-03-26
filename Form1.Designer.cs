namespace Arc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SettingWindow = new Button();
            MainWindow = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SaveRoundButton = new Button();
            HistoryButton = new Button();
            SuspendLayout();
            // 
            // SettingWindow
            // 
            SettingWindow.Location = new Point(112, 12);
            SettingWindow.Name = "SettingWindow";
            SettingWindow.Size = new Size(94, 29);
            SettingWindow.TabIndex = 0;
            SettingWindow.Text = "Settings";
            SettingWindow.UseVisualStyleBackColor = true;
            SettingWindow.Click += button1_Click;
            // 
            // MainWindow
            // 
            MainWindow.Location = new Point(12, 12);
            MainWindow.Name = "MainWindow";
            MainWindow.Size = new Size(94, 29);
            MainWindow.TabIndex = 22;
            MainWindow.Text = "Main";
            MainWindow.UseVisualStyleBackColor = true;
            MainWindow.Click += MainWindow_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 605);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 605);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(374, 605);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(547, 605);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(720, 605);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(893, 605);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 28;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1066, 605);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 566);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 30;
            label1.Text = "Downed Raiders:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 566);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 31;
            label2.Text = "Knocked out Raiders:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 566);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 32;
            label3.Text = "First Strikes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 566);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 33;
            label4.Text = "Non Squad revives:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(736, 566);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 34;
            label5.Text = "DMG Dealt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(908, 566);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 35;
            label6.Text = "DMG Received:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1050, 566);
            label7.Name = "label7";
            label7.Size = new Size(160, 20);
            label7.TabIndex = 36;
            label7.Text = "Looted Raider corpses:";
            // 
            // SaveRoundButton
            // 
            SaveRoundButton.Location = new Point(400, 663);
            SaveRoundButton.Name = "SaveRoundButton";
            SaveRoundButton.Size = new Size(301, 29);
            SaveRoundButton.TabIndex = 37;
            SaveRoundButton.Text = "Save Round";
            SaveRoundButton.UseVisualStyleBackColor = true;
            SaveRoundButton.Click += SaveRoundButton_Click;
            // 
            // HistoryButton
            // 
            HistoryButton.Location = new Point(212, 12);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(94, 29);
            HistoryButton.TabIndex = 38;
            HistoryButton.Text = "History";
            HistoryButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 741);
            Controls.Add(HistoryButton);
            Controls.Add(SaveRoundButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(MainWindow);
            Controls.Add(SettingWindow);
            Name = "Form1";
            Text = "MainTab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SettingWindow;
        private Button MainWindow;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button SaveRoundButton;
        private Button HistoryButton;
    }
}
