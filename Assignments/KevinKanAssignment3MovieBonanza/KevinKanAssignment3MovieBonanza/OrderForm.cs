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
                for (int i = 0; i < value.Length; i++)
                {
                    passData[i] = value[i];
                }
            }//end of set
        }//end PassData
       //END OF SET FUNCTIONS

        public OrderForm()
        {
            InitializeComponent();
            passData[4] = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {//hide this form and show previous form
            this.Hide();
            previousForm.Show();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {// when form is activated fill in all of the items in the form

        }

        private void StreamButton_Click(object sender, EventArgs e)
        {//Go to next form (stream form)
            newStream.PassData = passData;
            this.Hide();
            newStream.Show();
        }
    }
}
