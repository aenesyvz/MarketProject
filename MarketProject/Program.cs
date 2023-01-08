using MarketProject.Forms.Admin;
using MarketProject.Forms.LoginScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject.Forms.LoginScreen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginScreen loginScreen = new LoginScreen();
            if(loginScreen.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
