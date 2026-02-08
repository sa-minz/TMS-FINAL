using System;
using System.Windows.Forms;

namespace TMS_FINAL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Change this to the name of your main form
            Application.Run(new Login());

        }
    }
}
