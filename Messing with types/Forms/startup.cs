using System;
using System.Windows.Forms;

namespace Messing_with_types.Forms
{
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Startup.AccountForm.Show();
            Startup.AccountForm.ShowControl(ControlsEnum.LOGIN_CONTROL);
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Startup.AccountForm.Show();
            Startup.AccountForm.ShowControl(ControlsEnum.SIGNUP_CONTROL);
        }
    }
}
