using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Arc
{
    public partial class History : Form
    {
        private readonly string historyFilePath = "history.json";

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // Check if the history file exists
            if (File.Exists(historyFilePath))
            {
                // Read the file and convert it back into a List of MatchRecords
                string json = File.ReadAllText(historyFilePath);
                List<MatchRecord> matchHistory = JsonSerializer.Deserialize<List<MatchRecord>>(json) ?? new List<MatchRecord>();

                // //binding the List of MatchRecords to the DataGridView
                historyGridView.DataSource = matchHistory;
            }
        }

        // Navigation Logic
        private void MainWindow_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes History, unhiding Main
        }

        private void SettingWindow_Click(object sender, EventArgs e)
        {
            Settings settingsPage = new Settings();
            this.Hide();
            settingsPage.ShowDialog();
            this.Show();
        }
    }
}