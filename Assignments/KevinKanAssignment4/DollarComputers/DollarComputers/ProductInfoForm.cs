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
 * Product Info form. Show summary of what computer was selected. Allows user to save the order.
 * */
namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        OrderForm orderForm = new OrderForm();
        private StreamReader loadData;
        private StreamWriter saveData;
        private SelectForm previousForm;
        private ArrayList computerSpecs = new ArrayList();
        //set previous form
        public SelectForm PreviousForm
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
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            previousForm.ComputerSpecs = computerSpecs;
            this.Hide();
            previousForm.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            orderForm.ComputerSpecs = computerSpecs;
            orderForm.PreviousForm = this;
            this.Hide();
            orderForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIdTextBox.Text = computerSpecs[0].ToString();
            CostTextBox.Text=computerSpecs[1].ToString();
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
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult responceDialogResult;//instantiat dialog checks
            //	Begin	in	the	project	folder.	
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            //	Display	the	File	Open	dialog	box.	
            responceDialogResult = openFileDialog1.ShowDialog();
            if (responceDialogResult != DialogResult.Cancel)
            {	//	User	didn’t	click	the	Cancel	button.	
                //	Open	the	output	ﬁle.	
                computerSpecs.Clear();
                loadData = new StreamReader(openFileDialog1.FileName);
                //pass loadData info and closes stream
                while (loadData.Peek() != -1)
                {
                    computerSpecs.Add(loadData.ReadLine());
                }
                loadData.Close();
                ProductInfoForm_Activated(sender, e);
            }//end if
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DialogResult saveResponceDialogResult;//instantiat dialog checks
            //	Begin	in	the	project	folder.	
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            //	Display	the	File	Open	dialog	box.	
            saveResponceDialogResult = saveFileDialog1.ShowDialog();
            if (saveResponceDialogResult != DialogResult.Cancel)
            {	//	User	didn’t	click	the	Cancel	button.	
                saveData = new StreamWriter(saveFileDialog1.FileName);
                foreach (var item in computerSpecs)
                {
                    saveData.WriteLine(item.ToString());
                }
                saveData.Close();
            }
        }//end openToolSripMenuItem
    }//end partial class
}
