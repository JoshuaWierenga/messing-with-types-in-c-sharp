using Messing_with_types.Forms;
using Messing_with_types.Forms.Control_Forms;
using System;
using System.Windows.Forms;

namespace Messing_with_types
{
    static class Startup
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startup = new startup();
            accountguicontrol = new Account_Control_Form();
            mainguicontrol = new Main_Control_Form();
            Application.Run(startup);

        }

        private static startup startup;
        private static Account_Control_Form accountguicontrol;
        private static Main_Control_Form mainguicontrol;

        public static startup startupForm
        {
            get { return startup; }
        }

        public static Account_Control_Form AccountForm
        {
            get { return accountguicontrol; }
        }

        public static Main_Control_Form MainForm
        {
            get { return mainguicontrol; }
        }
    }
}