using System.Collections.Generic;
using System.Windows.Forms;

namespace level
{
    public partial class Account_Control_Form : Form
    {
        private Dictionary<ControlsEnum, Control> controls = new Dictionary<ControlsEnum, Control>();

        public Account_Control_Form()
        {
            InitializeComponent();
            ShowControl(ControlsEnum.LOGIN_CONTROL);
        }

        public void ShowControl(ControlsEnum ctrl)
        {
            Control new_ctrl = null;

            if (controls.ContainsKey(ctrl))
            {
                new_ctrl = controls[ctrl];
            }
            else
            {
                new_ctrl = CreateControl(ctrl);
                controls[ctrl] = new_ctrl;
            }

            new_ctrl.Parent = this;
            new_ctrl.Dock = DockStyle.Fill;
            new_ctrl.BringToFront();
            new_ctrl.Show();
        }

        private Control CreateControl(ControlsEnum ctrl)
        {
            switch (ctrl)
            {
                case ControlsEnum.LOGIN_CONTROL:
                    return new Signin();
                case ControlsEnum.SIGNUP_CONTROL:
                    return new Signup();
                default:
                    return null;
            }
        }

        
    }
}
