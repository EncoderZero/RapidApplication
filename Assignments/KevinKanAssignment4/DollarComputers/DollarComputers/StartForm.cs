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
        ProductInfoForm productForm = new ProductInfoForm();
        ArrayList computerSpecs=new ArrayList();
        private StreamReader loadData;
        public StartForm()
        {
            InitializeComponent();
            productForm.PreviousForm = selectionForm;//sets the previous form for productForm
            selectionForm.NextForm = productForm;//sets the next form for selectionForm
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {//sends the location for the next form for selectionForm and diplays selectionForm.
            this.Hide();
            selectionForm.ShowDialog();
        }

        private void LoadOrderButton_Click(object sender, EventArgs e)
        {//skip to product info form with all loaded data
            DialogResult responceDialogResult;//instantiat dialog checks
            //	Begin	in	the	project	folder.	
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            //	Display	the	File	Open	dialog	box.	
            responceDialogResult = openFileDialog1.ShowDialog();
            if (responceDialogResult != DialogResult.Cancel)
            {	//	User	didn’t	click	the	Cancel	button.	
                //	Open	the	output	ﬁle.	
                loadData = new StreamReader(openFileDialog1.FileName.ToString());
                //pass loadData info and closes stream
                while (loadData.Peek() != -1) {
                    computerSpecs.Add(loadData.ReadLine().ToString());
                }
                productForm.ComputerSpecs = computerSpecs;
                loadData.Close();
                //hide this form
                this.Hide();
                //show ProductInfoForm
                productForm.ShowDialog();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//end of class
}
