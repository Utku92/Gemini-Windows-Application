using System;
using System.Windows.Forms;

namespace Gemini
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Launch the main standalone client window
            Application.Run(new MainForm());
        }
    }
}