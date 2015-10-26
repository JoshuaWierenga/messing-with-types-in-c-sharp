using System;
using System.Windows.Forms;

namespace level
{
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            if (playerInfo.createUser(UsernameBox.Text, PasswordBox.Text) == true)
            {
                Program.AccountForm.ShowControl(ControlsEnum.LOGIN_CONTROL);

            }
        }

        private void Gotosignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.AccountForm.ShowControl(ControlsEnum.LOGIN_CONTROL);
        }
    }
}