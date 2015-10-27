using System.Windows.Forms;

namespace Messing_with_types.Forms.main
{
    public partial class Main : UserControl
    {
        public Main(PlayerInfo playerinfo)
        {
            if (playerinfo.isLoggedin != true)
            {
                Startup.startupForm.Show();
                Startup.MainForm.Hide();
            }

            InitializeComponent();
            NameBox.Text = playerinfo.Displayname;
        }
    }
}
