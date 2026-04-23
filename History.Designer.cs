namespace Arc
{
    partial class History
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
            HistoryButton = new Button();
            MainWindow = new Button();
            SettingWindow = new Button();
            historyGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)historyGridView).BeginInit();
            SuspendLayout();
            // 
            // HistoryButton
            // 
            HistoryButton.Location = new Point(212, 12);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(94, 29);
            HistoryButton.TabIndex = 41;
            HistoryButton.Text = "History";
            HistoryButton.UseVisualStyleBackColor = true;
            HistoryButton.Click += History_Load;
            // 
            // MainWindow
            // 
            MainWindow.Location = new Point(12, 12);
            MainWindow.Name = "MainWindow";
            MainWindow.Size = new Size(94, 29);
            MainWindow.TabIndex = 40;
            MainWindow.Text = "Main";
            MainWindow.UseVisualStyleBackColor = true;
            MainWindow.Click += MainWindow_Click;
            // 
            // SettingWindow
            // 
            SettingWindow.Location = new Point(112, 12);
            SettingWindow.Name = "SettingWindow";
            SettingWindow.Size = new Size(94, 29);
            SettingWindow.TabIndex = 39;
            SettingWindow.Text = "Settings";
            SettingWindow.UseVisualStyleBackColor = true;
            SettingWindow.Click += SettingWindow_Click;
            // 
            // historyGridView
            // 
            historyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyGridView.Location = new Point(2, 54);
            historyGridView.Name = "historyGridView";
            historyGridView.RowHeadersWidth = 51;
            historyGridView.Size = new Size(1453, 1365);
            historyGridView.TabIndex = 42;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 1418);
            Controls.Add(historyGridView);
            Controls.Add(HistoryButton);
            Controls.Add(MainWindow);
            Controls.Add(SettingWindow);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)historyGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HistoryButton;
        private Button MainWindow;
        private Button SettingWindow;
        private DataGridView historyGridView;
    }
}