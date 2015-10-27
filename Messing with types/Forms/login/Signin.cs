using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Messing_with_types.Forms.login
{
    public partial class Signin : UserControl
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            PlayerInfo user = new PlayerInfo(UsernameBox.Text);
            Console.WriteLine(UsernameBox.Text + " : " + user.ID);
            if (user.ID != -1)
            {
                Console.WriteLine(PasswordBox.Text + " : " + PlayerInfo.checkPassword(user, PasswordBox.Text));
                if (PlayerInfo.checkPassword(user, PasswordBox.Text) == true)
                {
                    PlayerInfo.login(user);
                    if (user.isLoggedin)
                    {
                        Startup.startupForm.Hide();
                        Startup.AccountForm.Hide();
                        Startup.MainForm.Show();
                        Startup.MainForm.ShowControl(ControlsEnum.MAIN_CONTROL, user);
                    }
                }
            }
        }

        private void Gotosignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Startup.AccountForm.ShowControl(ControlsEnum.SIGNUP_CONTROL);
        }
    }
}
