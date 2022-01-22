using System;
using System.Windows.Forms;

namespace NetsiFlat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // FileConnectorProcessor.CreateFolder();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Netsi());
        }
    }
}
