using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/**Author Kevin Kan
 * Version Nov 24 2013
 * Program to simulate the purchase of a computer
 * 
 * */
namespace DollarComputers
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
            KKSplashPAge splashPage = new KKSplashPAge();
            splashPage.ShowDialog();
            Application.Run(new StartForm());
        }
    }
}
