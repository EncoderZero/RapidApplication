using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
/**Author Kevin Kan
 * Version Nov 24 2013
 * Program to simulate the purchase of a computer
 * SelectForm, allows user to select computer from database 
 * */
namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        private ProductInfoForm nextForm;
        private ArrayList computerSpecs =new ArrayList();
        private decimal costDecimal = 0m;
        //set next form
        public ProductInfoForm NextForm
        {
            set
            {
                nextForm = value;
            }
        }
        public ArrayList ComputerSpecs {
            set {
                computerSpecs = value;
                NextButton.Enabled = true;
            }
        }
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarcomputersDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.dollarcomputersDataSet1.products);
            NextButton.Enabled = false;
        }

        private void SelectionDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {//on click anywhere
            DataGridViewRow row = this.SelectionDataGridView1.Rows[e.RowIndex];//get entire row selected
            computerSpecs.Clear();
            NextButton.Enabled = true;
           foreach (DataGridViewCell item in row.Cells)
	        {
                computerSpecs.Add(item.Value.ToString());
	        }//end foreach
            decimal.TryParse(computerSpecs[1].ToString(),out costDecimal);
            computerSpecs[1] = costDecimal.ToString("C");
            ModelChoosenTextBox.Text = computerSpecs[2]+" "+computerSpecs[3]+" Priced At :"+computerSpecs[1];
        }//end click anywhere

        private void NextButton_Click(object sender, EventArgs e)
        {
                nextForm.ComputerSpecs = computerSpecs;
                this.Hide();
                nextForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Activated(object sender, EventArgs e)
        {
            if (computerSpecs.Count > 0)
            {
                ModelChoosenTextBox.Text = computerSpecs[2].ToString() + " " + computerSpecs[3].ToString() + " Priced At :" + computerSpecs[1].ToString();
            }
        }
    }
}
