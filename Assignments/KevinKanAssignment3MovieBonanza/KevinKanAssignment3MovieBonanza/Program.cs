using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Schema; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinKanAssignment3MovieBonanza
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
            Application.Run(new SelectionForm());
        }
    }
}
