using System;
using System.Windows.Forms;

namespace level
{
    public partial class Signin : UserControl
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            playerInfo user = new playerInfo(UsernameBox.Text);
            Console.WriteLine(UsernameBox.Text + " : " + user.playerID);
            if (user.playerID != -1)
            {
                Console.WriteLine(PasswordBox.Text + " : " + playerInfo.checkPassword(user, PasswordBox.Text));
                if (playerInfo.checkPassword(user, PasswordBox.Text) == true )
                {
                    playerInfo.login(user);
                    if (user.isLoggedin)
                    {
                        Program.startupForm.Hide();
                        Program.AccountForm.Hide();
                        Program.MainForm.Show();
                        Program.MainForm.ShowControl(ControlsEnum.MAIN_CONTROL, user);
                    }
                }

            }
        }

        private void Gotosignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.AccountForm.ShowControl(ControlsEnum.SIGNUP_CONTROL);
        }
    }

}