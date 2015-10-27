using System;
using System.Windows.Forms;

namespace Messing_with_types.Forms.login
{
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            if (PlayerInfo.createUser(UsernameBox.Text, PasswordBox.Text) == true)
            {
                Startup.AccountForm.ShowControl(ControlsEnum.LOGIN_CONTROL);

            }
        }

        private void Gotosignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Startup.AccountForm.ShowControl(ControlsEnum.LOGIN_CONTROL);
        }
    }
}
