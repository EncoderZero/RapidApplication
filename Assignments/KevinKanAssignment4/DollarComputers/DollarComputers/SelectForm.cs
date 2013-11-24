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
 * SelectForm, allows user to select computer from database 
 * */
namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        private Form nextForm;
        //set next form
        public Form NextForm
        {
            set
            {
                nextForm = value;
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

        }

        private void SelectionDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {//on click anywhere
            DataGridViewRow row = this.SelectionDataGridView1.Rows[e.RowIndex];//get entire row selected
            ModelChoosenTextBox.Text = row.Cells["costDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            nextForm.Show();
        }
    }
}
