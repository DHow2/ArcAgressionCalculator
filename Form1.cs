using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace Arc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainWindow_Click(object sender, EventArgs e)
        {

        }

        private void SettingWindow_Click(object sender, EventArgs e)
        {
            // Create an instance of the Settings form
            Settings settingsPage = new Settings();

            // Hide the Main Window before showing the Settings page
            this.Hide();

            // Shows the Settings page
            // ShowDialog()  displays the settings page until it is closed, preventing the Main Window from showing up again until it is closed
            settingsPage.ShowDialog();

            // After the Settings page is closed, unhide the Main Window again
            this.Show();
        }

        private void SaveRoundButton_Click(object sender, EventArgs e)
        {
            string settingsFilePath = "settings.json";
            AggroSettings settings = AggroSettings.LoadFromFile(settingsFilePath);
            double downed = 0, knocked = 0, firstStrike = 0, revives = 0;
            double dmgDealt = 0, dmgReceived = 0, looted = 0;
            double.TryParse(txtDowned.Text, out downed);
            double.TryParse(txtKnocked.Text, out knocked);
            double.TryParse(txtFirstStrike.Text, out firstStrike);
            double.TryParse(txtRevives.Text, out revives);
            double.TryParse(txtDmgDealt.Text, out dmgDealt);
            double.TryParse(txtDmgRec.Text, out dmgReceived);
            double.TryParse(txtLooted.Text, out looted);
            double matchScore = (downed * settings.DownedMultiplier) +
                                (knocked * settings.KnockedMultiplier) +
                                (firstStrike * settings.FirstStrikeMultiplier) +
                                (revives * settings.RevivedMultiplier) +
                                (dmgDealt * settings.DmgInflictedMultiplier) +
                                (dmgReceived * settings.DmgReceivedMultiplier) +
                                (looted * settings.LootedMultiplier);

            predictedAgroBox.Text = matchScore.ToString("0.00");

            //placeholder
            if (matchScore > 150)
            {
                //placeholder
                predictedLobbyBox.Text = "High Aggro (Ramge Lobbies)";
            }
            else
            {
                //placeholder
                predictedLobbyBox.Text = "Standard";
            }

            if (RaiderNameBox.Text.Trim().Equals("Ramge", StringComparison.OrdinalIgnoreCase))
            {
                predictedLobbyBox.Text = "Extreme PVP Lobby";
            }

            {

                // Create a new Record with the current data.
                MatchRecord currentMatch = new MatchRecord
                {
                    RaiderName = RaiderNameBox.Text.Trim(),
                    AggroScore = matchScore,
                    PredictedLobby = predictedLobbyBox.Text,
                    Downed = downed,
                    KnockedOut = knocked,
                    FirstStrikes = firstStrike,
                    Revives = revives,
                    DmgDealt = dmgDealt,
                    DmgReceived = dmgReceived,
                    Looted = looted
                };

                // Prepare list and set file path
                string historyFilePath = "history.json";
                List<MatchRecord> matchHistory = new List<MatchRecord>();

                // Load if it exists, otherwise we'll just start with an empty list
                if (File.Exists(historyFilePath))
                {
                    string json = File.ReadAllText(historyFilePath);
                    matchHistory = JsonSerializer.Deserialize<List<MatchRecord>>(json) ?? new List<MatchRecord>();
                }

                // Add new match to the list
                matchHistory.Add(currentMatch);

                // Save updated list back to file. 
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(historyFilePath, JsonSerializer.Serialize(matchHistory, options));
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            History historyPage = new History();
            this.Hide();
            historyPage.ShowDialog();
            this.Show();
        }
    }
}
