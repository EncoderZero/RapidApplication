using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**Author Kevin Kan
 * Version Nov 24 2013
 * Program to simulate the purchase of a computer
 * Order form. Summary of user's order and last chance to backout, has file,edit and help menus. Allows for print , finish, back and terminate application.
 * */

namespace DollarComputers
{
    public partial class OrderForm : Form
    {
        AboutBox1 help = new AboutBox1();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Print the form on the print preview
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }
    }
}
