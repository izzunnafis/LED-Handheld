using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Handheld_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            Form flogin = new Forms.FormLogin();

            if (flogin.ShowDialog() == DialogResult.OK)
                Application.Run(new MainMenu());
            else
                Application.Exit();
        }
    }
}
