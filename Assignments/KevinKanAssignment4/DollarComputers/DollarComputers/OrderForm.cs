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
        private Form previousForm;
        //set previous form
        public Form PreviousForm
        {
            set
            {
                previousForm = value;
            }
        }
        decimal taxDecimal = 0m,totalCostDecimal = 0m,costDecimal=0m;
        const decimal TAX_RATEDecimal = 0.13m;
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

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your purchase. \n \n The computer will arrive within 7-10 business days","Thank You For Using Dollar Computers",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            decimal.TryParse(CostTextBox.Text, out costDecimal);
            taxDecimal = costDecimal * TAX_RATEDecimal;
            totalCostDecimal = costDecimal + taxDecimal;
            TaxTextBox.Text = taxDecimal.ToString("C");
            TotalTextBox.Text = totalCostDecimal.ToString("C");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }
    }
}
