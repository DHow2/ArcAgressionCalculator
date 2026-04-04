namespace Arc
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textDowned = new TextBox();
            textKnocked = new TextBox();
            textRev = new TextBox();
            textDMG = new TextBox();
            textDMGRec = new TextBox();
            textLooted = new TextBox();
            textFirst = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MainWindow = new Button();
            SettingWindow = new Button();
            HistoryButton = new Button();
            SaveSettingsButton = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textDowned
            // 
            textDowned.Location = new Point(21, 39);
            textDowned.Name = "textDowned";
            textDowned.Size = new Size(125, 27);
            textDowned.TabIndex = 6;
            // 
            // textKnocked
            // 
            textKnocked.Location = new Point(21, 126);
            textKnocked.Name = "textKnocked";
            textKnocked.Size = new Size(125, 27);
            textKnocked.TabIndex = 7;
            // 
            // textRev
            // 
            textRev.Location = new Point(21, 300);
            textRev.Name = "textRev";
            textRev.Size = new Size(125, 27);
            textRev.TabIndex = 8;
            // 
            // textDMG
            // 
            textDMG.Location = new Point(21, 387);
            textDMG.Name = "textDMG";
            textDMG.Size = new Size(125, 27);
            textDMG.TabIndex = 9;
            // 
            // textDMGRec
            // 
            textDMGRec.Location = new Point(21, 474);
            textDMGRec.Name = "textDMGRec";
            textDMGRec.Size = new Size(125, 27);
            textDMGRec.TabIndex = 10;
            // 
            // textLooted
            // 
            textLooted.Location = new Point(21, 561);
            textLooted.Name = "textLooted";
            textLooted.Size = new Size(125, 27);
            textLooted.TabIndex = 11;
            // 
            // textFirst
            // 
            textFirst.Location = new Point(21, 213);
            textFirst.Name = "textFirst";
            textFirst.Size = new Size(125, 27);
            textFirst.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 46);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 14;
            label1.Text = "Downed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 132);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 15;
            label2.Text = "Knocket out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 218);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 16;
            label3.Text = "First Strikes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 304);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 17;
            label4.Text = "Revived";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 390);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 18;
            label5.Text = "DMG inflicted";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 476);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 19;
            label6.Text = "DMG Received";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 562);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 20;
            label7.Text = "Looted Raiders";
            // 
            // MainWindow
            // 
            MainWindow.Location = new Point(12, 12);
            MainWindow.Name = "MainWindow";
            MainWindow.Size = new Size(94, 29);
            MainWindow.TabIndex = 21;
            MainWindow.Text = "Main";
            MainWindow.UseVisualStyleBackColor = true;
            MainWindow.Click += MainWindow_Click;
            // 
            // SettingWindow
            // 
            SettingWindow.Location = new Point(112, 12);
            SettingWindow.Name = "SettingWindow";
            SettingWindow.Size = new Size(94, 29);
            SettingWindow.TabIndex = 22;
            SettingWindow.Text = "Settings";
            SettingWindow.UseVisualStyleBackColor = true;
            SettingWindow.Click += SettingWindow_Click;
            // 
            // HistoryButton
            // 
            HistoryButton.Location = new Point(212, 12);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(94, 29);
            HistoryButton.TabIndex = 39;
            HistoryButton.Text = "History";
            HistoryButton.UseVisualStyleBackColor = true;
            HistoryButton.Click += HistoryButton_Click;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Location = new Point(12, 733);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(562, 60);
            SaveSettingsButton.TabIndex = 40;
            SaveSettingsButton.Text = "Save  Settings";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            SaveSettingsButton.Click += SaveSettingsButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textDowned);
            groupBox1.Controls.Add(textKnocked);
            groupBox1.Controls.Add(textRev);
            groupBox1.Controls.Add(textDMG);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textDMGRec);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textLooted);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textFirst);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(127, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 624);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 828);
            Controls.Add(groupBox1);
            Controls.Add(SaveSettingsButton);
            Controls.Add(HistoryButton);
            Controls.Add(SettingWindow);
            Controls.Add(MainWindow);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textDowned;
        private TextBox textKnocked;
        private TextBox textRev;
        private TextBox textDMG;
        private TextBox textDMGRec;
        private TextBox textLooted;
        private TextBox textFirst;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button MainWindow;
        private Button SettingWindow;
        private Button HistoryButton;
        private Button SaveSettingsButton;
        private GroupBox groupBox1;
    }
}