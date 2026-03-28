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
            txtFirstStrike = new TextBox();
            txtRevives = new TextBox();
            trxtDmgDealt = new TextBox();
            txtDmgRec = new TextBox();
            txtLooted = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // txtDowned
            // 
            txtDowned.Location = new Point(28, 605);
            txtDowned.Name = "txtDowned";
            txtDowned.Size = new Size(125, 27);
            txtDowned.TabIndex = 23;
            // 
            // txtKnocked
            // 
            txtKnocked.Location = new Point(201, 605);
            txtKnocked.Name = "txtKnocked";
            txtKnocked.Size = new Size(125, 27);
            txtKnocked.TabIndex = 24;
            // 
            // txtFirstStrike
            // 
            txtFirstStrike.Location = new Point(374, 605);
            txtFirstStrike.Name = "txtFirstStrike";
            txtFirstStrike.Size = new Size(125, 27);
            txtFirstStrike.TabIndex = 25;
            // 
            // txtRevives
            // 
            txtRevives.Location = new Point(547, 605);
            txtRevives.Name = "txtRevives";
            txtRevives.Size = new Size(125, 27);
            txtRevives.TabIndex = 26;
            // 
            // trxtDmgDealt
            // 
            trxtDmgDealt.Location = new Point(720, 605);
            trxtDmgDealt.Name = "trxtDmgDealt";
            trxtDmgDealt.Size = new Size(125, 27);
            trxtDmgDealt.TabIndex = 27;
            // 
            // txtDmgRec
            // 
            txtDmgRec.Location = new Point(893, 605);
            txtDmgRec.Name = "txtDmgRec";
            txtDmgRec.Size = new Size(125, 27);
            txtDmgRec.TabIndex = 28;
            // 
            // txtLooted
            // 
            txtLooted.Location = new Point(1066, 605);
            txtLooted.Name = "txtLooted";
            txtLooted.Size = new Size(125, 27);
            txtLooted.TabIndex = 29;
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
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(243, 137);
            label8.Name = "label8";
            label8.Size = new Size(184, 28);
            label8.TabIndex = 39;
            label8.Text = "Current Agro Score:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(810, 137);
            label9.Name = "label9";
            label9.Size = new Size(159, 28);
            label9.TabIndex = 40;
            label9.Text = "Predicted Lobby:";
            // 
            // predictedAgroBox
            // 
            predictedAgroBox.Location = new Point(243, 183);
            predictedAgroBox.Name = "predictedAgroBox";
            predictedAgroBox.Size = new Size(184, 27);
            predictedAgroBox.TabIndex = 41;
            // 
            // predictedLobbyBox
            // 
            predictedLobbyBox.Location = new Point(810, 183);
            predictedLobbyBox.Name = "predictedLobbyBox";
            predictedLobbyBox.Size = new Size(184, 27);
            predictedLobbyBox.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 741);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLooted);
            Controls.Add(txtDmgRec);
            Controls.Add(trxtDmgDealt);
            Controls.Add(txtRevives);
            Controls.Add(txtFirstStrike);
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
        private TextBox txtFirstStrike;
        private TextBox txtRevives;
        private TextBox trxtDmgDealt;
        private TextBox txtDmgRec;
        private TextBox txtLooted;
        private Label label1;
        private Label label2;
        private Label label3;
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
    }
}
