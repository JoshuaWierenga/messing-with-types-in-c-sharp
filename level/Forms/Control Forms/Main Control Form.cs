using level.Forms.main;
using System.Collections.Generic;
using System.Windows.Forms;

namespace level
{
    public partial class Main_Control_Form : Form
    {
        private Dictionary<ControlsEnum, Control> controls = new Dictionary<ControlsEnum, Control>();

        public Main_Control_Form()
        {
            InitializeComponent();
        }

        public void ShowControl(ControlsEnum ctrl, playerInfo playerinfo)
        {
            Control new_ctrl = null;

            if (controls.ContainsKey(ctrl))
            {
                new_ctrl = controls[ctrl];
            }
            else
            {
                new_ctrl = CreateControl(ctrl, playerinfo);
                controls[ctrl] = new_ctrl;
            }

            new_ctrl.Parent = this;
            new_ctrl.Dock = DockStyle.Fill;
            new_ctrl.BringToFront();
            new_ctrl.Show();
        }

        private Control CreateControl(ControlsEnum ctrl, playerInfo playerinfo)
        {
            switch (ctrl)
            {
                case ControlsEnum.MAIN_CONTROL:
                    return new Main(playerinfo);
                default:
                    return null;
            }
        }

        
    }
}
