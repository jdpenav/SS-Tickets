using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
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
            if (Properties.Settings.Default.RememberMe && Properties.Settings.Default.FechaInicio > DateTime.Now)
                Application.Run(new FrmMenu());
            else
                Application.Run(new frmLogin());
        }
    }
}
