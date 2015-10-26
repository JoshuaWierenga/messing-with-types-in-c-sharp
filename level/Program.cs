using System;
using System.Windows.Forms;

namespace level
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startup = new Startup();
            accountguicontrol = new Account_Control_Form();
            mainguicontrol = new Main_Control_Form();
            Application.Run(startup);
            
        }

        private static Startup startup;
        private static Account_Control_Form accountguicontrol;
        private static Main_Control_Form mainguicontrol;

        public static Startup startupForm
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
