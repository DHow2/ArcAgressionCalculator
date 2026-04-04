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
            // !!ShowDialog()  displays the settings page until it is closed, preventing the Main Window from showing up again until it is closed!!
            settingsPage.ShowDialog();

            // After the Settings page is closed, unhide the Main Window again
            this.Show();
        }

        private void SaveRoundButton_Click(object sender, EventArgs e)
        {
            // Load settings
            string settingsFilePath = "settings.json";
            AggroSettings settings = AggroSettings.LoadFromFile(settingsFilePath);

            // Parse
            double downed = 0, knocked = 0, firstStrike = 0, revives = 0;
            double dmgDealt = 0, dmgReceived = 0, looted = 0;

            double.TryParse(txtDowned.Text, out downed);
            double.TryParse(txtKnocked.Text, out knocked);
            double.TryParse(txtFirstStrike.Text, out firstStrike);
            double.TryParse(txtRevives.Text, out revives);
            double.TryParse(txtDmgDealt.Text, out dmgDealt);
            double.TryParse(txtDmgRec.Text, out dmgReceived);
            double.TryParse(txtLooted.Text, out looted);

            // Calculate THIS round's score
            double currentMatchScore = (downed * settings.DownedMultiplier) +
                                       (knocked * settings.KnockedMultiplier) +
                                       (firstStrike * settings.FirstStrikeMultiplier) +
                                       (revives * settings.RevivedMultiplier) +
                                       (dmgDealt * settings.DmgInflictedMultiplier) +
                                       (dmgReceived * settings.DmgReceivedMultiplier) +
                                       (looted * settings.LootedMultiplier);

            // Create MatchRecord for this round
            MatchRecord currentMatch = new MatchRecord
            {
                RaiderName = RaiderNameBox.Text.Trim(),
                AggroScore = currentMatchScore,
                Downed = downed,
                KnockedOut = knocked,
                FirstStrikes = firstStrike,
                Revives = revives,
                DmgDealt = dmgDealt,
                DmgReceived = dmgReceived,
                Looted = looted
            };

            // Load History and add this match
            string historyFilePath = "history.json";
            List<MatchRecord> matchHistory = new List<MatchRecord>();

            if (File.Exists(historyFilePath))
            {
                string json = File.ReadAllText(historyFilePath);
                matchHistory = JsonSerializer.Deserialize<List<MatchRecord>>(json) ?? new List<MatchRecord>();
            }
            matchHistory.Add(currentMatch);

            // Calculate Rolling Average
            int n = settings.RollingAverageCount;

            double rollingAverage = matchHistory
                .TakeLast(n)
                .Average(m => m.AggroScore);

            // Update UI with the AVERAGE Score
            predictedAgroBox.Text = rollingAverage.ToString("0.00");

            if (rollingAverage < 10)
            {
                predictedLobbyBox.Text = "Carebear Lobby";
            }
            else if (rollingAverage < 25)
            {
                predictedLobbyBox.Text = "Mostly PVE Lobby";
            }
            else if (rollingAverage < 45)
            {
                predictedLobbyBox.Text = "Mixed Lobby";
            }
            else if (rollingAverage < 70)
            {
                predictedLobbyBox.Text = "Mostly PVP Lobby";
            }
            else
            {
                predictedLobbyBox.Text = "Pure PVP Lobby";
            }

            // RAMGI! :D
            if (RaiderNameBox.Text.Trim().Equals("Ramge", StringComparison.OrdinalIgnoreCase))
            {
                predictedLobbyBox.Text = "Extreme PVP Lobby";
            }

            // Finalize current MatchRecord with lobby prediction and save to JSON
            currentMatch.PredictedLobby = predictedLobbyBox.Text;

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(historyFilePath, JsonSerializer.Serialize(matchHistory, options));

            // Clear Boxes
            txtDowned.Clear();
            txtKnocked.Clear();
            txtFirstStrike.Clear();
            txtRevives.Clear();
            txtDmgDealt.Clear();
            txtDmgRec.Clear();
            txtLooted.Clear();
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
