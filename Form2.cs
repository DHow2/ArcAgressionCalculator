using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arc
{
    public partial class Settings : Form
    {
        // Settings
        private readonly string settingsFilePath = "settings.json";

        public Settings()
        {
            InitializeComponent();
        }

        // load settings
        private void Settings_Load(object sender, EventArgs e)
        {
            AggroSettings currentSettings = AggroSettings.LoadFromFile(settingsFilePath);

            textDowned.Text = currentSettings.DownedMultiplier.ToString();
            textKnocked.Text = currentSettings.KnockedMultiplier.ToString();
            textFirst.Text = currentSettings.FirstStrikeMultiplier.ToString();
            textRev.Text = currentSettings.RevivedMultiplier.ToString();
            textDMG.Text = currentSettings.DmgInflictedMultiplier.ToString();
            textDMGRec.Text = currentSettings.DmgReceivedMultiplier.ToString();
            textLooted.Text = currentSettings.LootedMultiplier.ToString();
            textZeroDMG.Text = currentSettings.ZeroDamage.ToString();
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            AggroSettings updatedSettings = new AggroSettings();

            // Note to self: Fucktard, remember TryParse!!!
            if (double.TryParse(textDowned.Text, out double downed)) updatedSettings.DownedMultiplier = downed;
            if (double.TryParse(textKnocked.Text, out double knocked)) updatedSettings.KnockedMultiplier = knocked;
            if (double.TryParse(textFirst.Text, out double first)) updatedSettings.FirstStrikeMultiplier = first;
            if (double.TryParse(textRev.Text, out double rev)) updatedSettings.RevivedMultiplier = rev;
            if (double.TryParse(textDMG.Text, out double dmg)) updatedSettings.DmgInflictedMultiplier = dmg;
            if (double.TryParse(textDMGRec.Text, out double dmgRec)) updatedSettings.DmgReceivedMultiplier = dmgRec;
            if (double.TryParse(textLooted.Text, out double looted)) updatedSettings.LootedMultiplier = looted;
            if (double.TryParse(textZeroDMG.Text, out double ZeroDamage)) updatedSettings.ZeroDamage = ZeroDamage;


            // Save to JSON file
            updatedSettings.SaveToFile(settingsFilePath);

            MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainWindow_Click(object sender, EventArgs e)
        {
            // Unhides the Main Window and closes the Settings page.
            this.Close();
        }

        private void SettingWindow_Click(object sender, EventArgs e)
        {

        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            History historyPage = new History();
            this.Close();
            historyPage.ShowDialog();
            this.Show();
        }
    }
}
