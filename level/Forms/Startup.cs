using System;
using System.Windows.Forms;

namespace level
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Program.AccountForm.Show();
            Program.AccountForm.ShowControl(ControlsEnum.SIGNUP_CONTROL);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Program.AccountForm.Show();
            Program.AccountForm.ShowControl(ControlsEnum.LOGIN_CONTROL);
        }

        public void text(string text)
        {
            Signup.Text = text;
        }
    }
}
