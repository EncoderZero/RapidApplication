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
    //Written By: Kevin Kan
    //Student No. 200213257
    //Version: Sept 22 2013
    //This application calculates the bonus for employees based on total sales in the four
    //week period and how much they worked in that four week period. (the can gain a max of 2% for working the max
    //160 hours)
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
            //Reset the calculation for the next employee
            EmployeeNameText.Text = "";
            EmployeeIdText.Text = "";
            TotalHoursWorkedText.Text = "";
            SalesBonusText.Text = "";
        }

        private void SelectEnglishButton_CheckedChanged(object sender, EventArgs e)
        {
            //Change all text into English
            //Note: if this wasn't so small would create seperate class to handle content change, would not hard code
            SelectLanguageGroupBox.Text = "Select Language";
            MonthlyTotalSalesLabel.Text = "Total Monthly Sales";
            EmployeeNameLabel.Text = "Employee Name";
            EmployeeIdLabel.Text = "Employee Id";
            TotalHoursWorkedLabel.Text = "Total Hours Worked";
            SalesBonusLabel.Text = "Sales Bonus";
            CalculateButton.Text = "Calculate";
            PrintButton.Text = "Print";
            NextButton.Text = "Next";
        }

        private void SelectFrancaisButton_CheckedChanged(object sender, EventArgs e)
        {//Switch Language to french
            SelectLanguageGroupBox.Text="Choisissez la Langue";
            MonthlyTotalSalesLabel.Text = "Ventes Mensuelles Totales";
            EmployeeNameLabel.Text = "Nom d'employé";
            EmployeeIdLabel.Text = "Employé Id";
            TotalHoursWorkedLabel.Text = "Les Heures Totales Ont Travaillé";
            SalesBonusLabel.Text = "Prime Des Ventes";
            CalculateButton.Text = "Calculer";
            PrintButton.Text = "Caractères";
            NextButton.Text = "Ensuite";
        }
    }
}
