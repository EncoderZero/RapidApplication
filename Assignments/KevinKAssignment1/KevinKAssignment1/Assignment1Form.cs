using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinKAssignment1
{
    public partial class Assignment1Form : Form
    {
        public Assignment1Form()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //Print the form on the print preview
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();

        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectEnglishButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SelectFrancaisButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
