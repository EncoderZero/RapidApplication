using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Resources;
using System.Globalization;
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
        private ArrayList computerSpecs = new ArrayList();
        private string imageReference;
        private decimal compCostDecimal;
        //set previous form
        public Form PreviousForm
        {
            set
            {
                previousForm = value;
            }
        }
        public ArrayList ComputerSpecs
        {
            set
            {
                computerSpecs = value;
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
            MessageBox.Show("Thank you for your purchase of "+computerSpecs[3].ToString().Trim()+" for "+totalCostDecimal.ToString("C").Trim()+". \n \n The computer will arrive within 7-10 business days","Thank You For Using Dollar Computers",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {//once form is activated set all fields
            //set text fields
            ProductIdTextBox.Text = computerSpecs[0].ToString();
            CostTextBox.Text = computerSpecs[1].ToString();
            ManufacturerTextBox.Text = computerSpecs[2].ToString();
            ModelTextBox.Text = computerSpecs[3].ToString();
            MemoryTextBox.Text = computerSpecs[5].ToString();
            LCDTextBox.Text = computerSpecs[7].ToString();
            CPUBrandTextBox.Text = computerSpecs[10].ToString();
            CPUTypeTextBox.Text = computerSpecs[11].ToString();
            CPUSpeedTextBox.Text = computerSpecs[12].ToString();
            CPUNumberTextBox.Text = computerSpecs[13].ToString();
            ConditionTextBox.Text = computerSpecs[14].ToString();
            OSTextBox.Text = computerSpecs[15].ToString();
            PlatformTextBox.Text = computerSpecs[16].ToString();
            HDDTextBox.Text = computerSpecs[17].ToString();
            GPUTextBox.Text = computerSpecs[19].ToString();
            WebCamTextBox.Text = computerSpecs[30].ToString();
            //set image by resourse manager, calling by name and replacing - with _ 
            imageReference = "_" + computerSpecs[3].ToString().Replace("-", "_");
            OrderPictureBox.BackgroundImage=(Image)Properties.Resources.ResourceManager.GetObject(imageReference.Trim());
            //calculate and set cost fields
            decimal.TryParse(CostTextBox.Text.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out compCostDecimal);
            taxDecimal = compCostDecimal * TAX_RATEDecimal;
            totalCostDecimal = compCostDecimal + taxDecimal;
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
