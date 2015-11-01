using System.Windows.Forms;

namespace Messing_with_types.Forms.main
{
    public partial class Main : UserControl
    {
        PlayerInfo playerinfo = new PlayerInfo(-1);
        public Main(PlayerInfo playerinfo2)
        {
            if (playerinfo2.isLoggedin != true)
            {
                Startup.MainForm.Hide();
                Startup.startupForm.Show();
            }

            InitializeComponent();
            playerinfo = playerinfo2;
            Refresh();
        }

        new void Refresh()
        {
            NameBox.Text = playerinfo.Displayname;
            LevelBox.Text = "Level: " + playerinfo.Level.ToString();
            RankBox.Text = "Rank: " + playerinfo.Rank;
        }

        private void Gain1Points_Click(object sender, System.EventArgs e)
        {
            playerinfo.setPoints(playerinfo.Points + 1);
            Refresh();
        }

        private void Gain10Points_Click(object sender, System.EventArgs e)
        {
            playerinfo.setPoints(playerinfo.Points + 10);
            Refresh();
        }

        private void Gain100Points_Click(object sender, System.EventArgs e)
        {
            playerinfo.setPoints(playerinfo.Points + 100);
            Refresh();
        }

        private void Gain1000Points_Click(object sender, System.EventArgs e)
        {
            playerinfo.setPoints(playerinfo.Points + 1000);
            Refresh();
        }

        private void Gain10000Points_Click(object sender, System.EventArgs e)
        {
            playerinfo.setPoints(playerinfo.Points + 10000);
            Refresh();
        }
    }
}