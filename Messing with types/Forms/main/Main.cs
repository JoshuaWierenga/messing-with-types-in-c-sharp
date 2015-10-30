using System.Windows.Forms;

namespace Messing_with_types.Forms.main
{
    public partial class Main : UserControl
    {
        public Main(PlayerInfo playerinfo)
        {
            if (playerinfo.isLoggedin != true)
            {
                Startup.MainForm.Hide();
                Startup.startupForm.Show();
            }

            InitializeComponent();
            NameBox.Text = playerinfo.Displayname;
            LevelBox.Text = "Level: " + playerinfo.Level.ToString();
        }
    }
}