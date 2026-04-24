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
            txtDowned = new TextBox();
            txtKnocked = new TextBox();
            txtRevives = new TextBox();
            txtDmgDealt = new TextBox();
            txtDmgRec = new TextBox();
            txtLooted = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SaveRoundButton = new Button();
            HistoryButton = new Button();
            label8 = new Label();
            label9 = new Label();
            predictedAgroBox = new TextBox();
            predictedLobbyBox = new TextBox();
            label10 = new Label();
            RaiderNameBox = new TextBox();
            label3 = new Label();
            label11 = new Label();
            predictedSkillBox = new TextBox();
            checkExtracted = new CheckBox();
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
            SettingWindow.Click += SettingWindow_Click;
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
            // txtDowned
            // 
            txtDowned.Location = new Point(26, 605);
            txtDowned.Name = "txtDowned";
            txtDowned.Size = new Size(123, 27);
            txtDowned.TabIndex = 23;
            // 
            // txtKnocked
            // 
            txtKnocked.Location = new Point(236, 605);
            txtKnocked.Name = "txtKnocked";
            txtKnocked.Size = new Size(148, 27);
            txtKnocked.TabIndex = 24;
            // 
            // txtRevives
            // 
            txtRevives.Location = new Point(471, 605);
            txtRevives.Name = "txtRevives";
            txtRevives.Size = new Size(135, 27);
            txtRevives.TabIndex = 26;
            // 
            // txtDmgDealt
            // 
            txtDmgDealt.Location = new Point(693, 605);
            txtDmgDealt.Name = "txtDmgDealt";
            txtDmgDealt.Size = new Size(86, 27);
            txtDmgDealt.TabIndex = 27;
            // 
            // txtDmgRec
            // 
            txtDmgRec.Location = new Point(866, 605);
            txtDmgRec.Name = "txtDmgRec";
            txtDmgRec.Size = new Size(110, 27);
            txtDmgRec.TabIndex = 28;
            // 
            // txtLooted
            // 
            txtLooted.Location = new Point(1063, 605);
            txtLooted.Name = "txtLooted";
            txtLooted.Size = new Size(160, 27);
            txtLooted.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 566);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 30;
            label1.Text = "Downed Raiders:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 566);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 31;
            label2.Text = "Knocked out Raiders:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 566);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 33;
            label4.Text = "Non Squad revives:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(693, 566);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 34;
            label5.Text = "DMG Dealt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(866, 566);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 35;
            label6.Text = "DMG Received:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1063, 566);
            label7.Name = "label7";
            label7.Size = new Size(160, 20);
            label7.TabIndex = 36;
            label7.Text = "Looted Raider corpses:";
            // 
            // SaveRoundButton
            // 
            SaveRoundButton.Location = new Point(471, 666);
            SaveRoundButton.Name = "SaveRoundButton";
            SaveRoundButton.Size = new Size(272, 29);
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
            HistoryButton.Click += HistoryButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(241, 146);
            label8.Name = "label8";
            label8.Size = new Size(184, 28);
            label8.TabIndex = 39;
            label8.Text = "Current Agro Score:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(808, 146);
            label9.Name = "label9";
            label9.Size = new Size(159, 28);
            label9.TabIndex = 40;
            label9.Text = "Predicted Lobby:";
            // 
            // predictedAgroBox
            // 
            predictedAgroBox.Location = new Point(241, 192);
            predictedAgroBox.Name = "predictedAgroBox";
            predictedAgroBox.Size = new Size(184, 27);
            predictedAgroBox.TabIndex = 41;
            // 
            // predictedLobbyBox
            // 
            predictedLobbyBox.Location = new Point(808, 192);
            predictedLobbyBox.Name = "predictedLobbyBox";
            predictedLobbyBox.Size = new Size(184, 27);
            predictedLobbyBox.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 78);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 43;
            label10.Text = "Hello";
            // 
            // RaiderNameBox
            // 
            RaiderNameBox.Location = new Point(93, 75);
            RaiderNameBox.Name = "RaiderNameBox";
            RaiderNameBox.Size = new Size(125, 27);
            RaiderNameBox.TabIndex = 44;
            RaiderNameBox.Text = "Raider";
            RaiderNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(396, 480);
            label3.Name = "label3";
            label3.Size = new Size(444, 20);
            label3.TabIndex = 45;
            label3.Text = "! Important ! Self defense will also increase your aggression score!";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(522, 279);
            label11.Name = "label11";
            label11.Size = new Size(194, 28);
            label11.TabIndex = 46;
            label11.Text = "Predicted Skill Score:";
            label11.Click += label11_Click;
            // 
            // predictedSkillBox
            // 
            predictedSkillBox.Location = new Point(522, 325);
            predictedSkillBox.Name = "predictedSkillBox";
            predictedSkillBox.Size = new Size(194, 27);
            predictedSkillBox.TabIndex = 47;
            // 
            // checkExtracted
            // 
            checkExtracted.AutoSize = true;
            checkExtracted.Location = new Point(1048, 671);
            checkExtracted.Name = "checkExtracted";
            checkExtracted.Size = new Size(175, 24);
            checkExtracted.TabIndex = 48;
            checkExtracted.Text = "Successfully Extracted";
            checkExtracted.UseVisualStyleBackColor = true;
            checkExtracted.CheckedChanged += checkExtracted_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 741);
            Controls.Add(checkExtracted);
            Controls.Add(predictedSkillBox);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(RaiderNameBox);
            Controls.Add(label10);
            Controls.Add(predictedLobbyBox);
            Controls.Add(predictedAgroBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(HistoryButton);
            Controls.Add(SaveRoundButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLooted);
            Controls.Add(txtDmgRec);
            Controls.Add(txtDmgDealt);
            Controls.Add(txtRevives);
            Controls.Add(txtKnocked);
            Controls.Add(txtDowned);
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
        private TextBox txtDowned;
        private TextBox txtKnocked;
        private TextBox txtRevives;
        private TextBox txtDmgDealt;
        private TextBox txtDmgRec;
        private TextBox txtLooted;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button SaveRoundButton;
        private Button HistoryButton;
        private Label label8;
        private Label label9;
        private TextBox predictedAgroBox;
        private TextBox predictedLobbyBox;
        private Label label10;
        private TextBox RaiderNameBox;
        private Label label3;
        private Label label11;
        private TextBox predictedSkillBox;
        private CheckBox checkExtracted;
    }
}
