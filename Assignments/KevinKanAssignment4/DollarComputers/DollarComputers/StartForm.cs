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
 * Start form. The initial form for the entire program. alows user to load saved info, start new order or quit application
 * */
namespace DollarComputers
{
    public partial class StartForm : Form
    {
        SelectForm selectionForm = new SelectForm();
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionForm.ShowDialog();
        }
    }
}
