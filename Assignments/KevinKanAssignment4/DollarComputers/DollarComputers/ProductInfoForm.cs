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
 * Product Info form. Show summary of what computer was selected. Allows user to save the order.
 * */
namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        OrderForm orderForm = new OrderForm();
        private Form previousForm;
        //set previous form
        public Form PreviousForm
        {
            set
            {
                previousForm = value;
            }
        }
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            orderForm.PreviousForm = this;
            this.Hide();
            orderForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
