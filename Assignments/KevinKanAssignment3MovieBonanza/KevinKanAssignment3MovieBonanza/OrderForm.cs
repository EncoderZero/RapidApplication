using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Author Kevin Kan
 * Version Nov 10 2013
 * Order form, display preview of movie they wish to stream along with recipt. also allow
 * user to order DVD for additional $10
 */
namespace KevinKanAssignment3MovieBonanza
{
    public partial class OrderForm : Form
    {
        //create about box and stream form
        AboutBox1 aboutBox = new AboutBox1();
        StreamForm newStream = new StreamForm();

        private string movieImage,movieName,movieCategory;
        private decimal cost,subtotal,tax,totalCost;

        private const decimal TAX_RATE=0.13m;

        string[] passData = new string[5]; //name,category,image,cost,dvdmessage
        private Form previousForm;
       //SET FUNCTIONS
        //set previous form
        public Form PreviousForm
        {
            set
            {
                previousForm = value;
            }
        }
        //pass along data from previous form selection
        public string[] PassData {
            set {
                passData = value;
            }//end of set
        }//end PassData
       //END OF SET FUNCTIONS

        public OrderForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {//hide this form and show previous form after reseting form elements to default
            DVDCheckBox.Checked = false;
            previousForm.Show();
            this.Hide();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {// when form is activated fill in all of the items in the form
            //set background image
            Image newImage = Image.FromFile("../../Resources/" + passData[2]);
            MoviePosterPictureBox.BackgroundImage = newImage;
            CostTextBox.Text = passData[3];
            TitleTextBox.Text = passData[0];
            CategoryTextBox.Text = passData[1];
            calculatePrice();
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {//Go to next form (stream form)
            //update total cost to pass for streaming
            passData[3] = totalCost.ToString("C");
            newStream.PassData = passData;
            this.Hide();
            newStream.Show();
        }//end of streamButton click

        public void calculatePrice() {
            //function to display and caluculations of the total cost of purchase
            decimal.TryParse(passData[3], out cost);
            subtotal = (DVDCheckBox.Checked)?cost + 10.00m:cost;
            tax = subtotal * TAX_RATE;
            totalCost = subtotal + tax;
            SubTotalTextBox.Text = subtotal.ToString("C");
            TaxTextBox.Text = tax.ToString("C");
            GrandTotalTextBox.Text = totalCost.ToString("C");
        }

        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passData[4] =(DVDCheckBox.Checked)? " and a DVD copy has been sent":"";
            calculatePrice();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Print the form on the print preview
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        } 
    }//end of class
}
