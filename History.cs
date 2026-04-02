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
            // 1. Check if the history file exists yet
            if (File.Exists(historyFilePath))
            {
                // 2. Read the file and convert it back into a List of MatchRecords
                string json = File.ReadAllText(historyFilePath);
                List<MatchRecord> matchHistory = JsonSerializer.Deserialize<List<MatchRecord>>(json) ?? new List<MatchRecord>();

                // 3. The Magic Step: Bind the list directly to the grid!
                // The DataGridView is smart enough to read the properties of MatchRecord and create columns automatically.
                historyGridView.DataSource = matchHistory;
            }
        }

        // --- Navigation Logic ---
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