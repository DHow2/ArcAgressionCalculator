using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Click(object sender, EventArgs e)
        {

        }

        private void SaveRoundButton_Click(object sender, EventArgs e)
        {
            AggroSettings settings = AggroSettings.LoadFromFile();
            double downed = 0, knocked = 0, firstStrike = 0, revives = 0;
            double dmgDealt = 0, dmgReceived = 0, looted = 0;
            double.TryParse(txtDowned.Text, out downed);
            double.TryParse(txtKnocked.Text, out knocked);
            double.TryParse(txtFirstStrike.Text, out firstStrike);
            double.TryParse(txtRevives.Text, out revives);
            double.TryParse(trxtDmgDealt.Text, out dmgDealt);
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

            if (matchScore > 150)
            {
                predictedLobbyBox.Text = "High Aggro (Sweaty)";
            }
            else
            {
                predictedLobbyBox.Text = "Standard";
            }
        }
    }
}
