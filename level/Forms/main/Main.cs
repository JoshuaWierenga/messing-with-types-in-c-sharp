using System.Windows.Forms;

namespace level.Forms.main
{
    public partial class Main : UserControl
    {
        public Main(playerInfo playerinfo)
        {
            if (playerinfo.isLoggedin != true)
            {
                Program.startupForm.Show();
                Program.MainForm.Hide();
            }

            InitializeComponent();
            NameBox.Text = playerinfo.playerDisplayname;
        }
    }
}
