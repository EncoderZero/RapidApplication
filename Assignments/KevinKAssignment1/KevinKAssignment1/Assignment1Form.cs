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
        private bool TotalMonthlySalesErrorBool = false;
        private bool TotalHoursWorkedErrorBool = false;

        public Assignment1Form()
        {
            InitializeComponent();
        }
        
        private void CalculateButton_Click(object sender, EventArgs e)
        {//do the calculation to determine the employee's bonus
            //declare Varibles
            decimal TotalMonthlySalesValueDecimal,EmployeeBonusDecimal;
            decimal TotalHoursWorkedValueDecimal;
            //declare constants
            const decimal BONUS_RATE_Decimal = 0.02m;
            const int MAX_TOTAL_HOURS_WORKED_Int = 160;
            if (Decimal.TryParse(TotalMonthlySalesTextBox.Text, System.Globalization.NumberStyles.Currency, null, out TotalMonthlySalesValueDecimal)&&(Decimal.TryParse(TotalHoursWorkedTextBox.Text, out TotalHoursWorkedValueDecimal)))
            {//if TotalMonthlySalesTextBox is Decimal with Curency allowence && TryParse TotalHoursWorkedTextBox.Text is decimal
                    EmployeeBonusDecimal = TotalMonthlySalesValueDecimal * BONUS_RATE_Decimal * TotalHoursWorkedValueDecimal / MAX_TOTAL_HOURS_WORKED_Int;
                    EmployeeBonusDecimal = Math.Round(EmployeeBonusDecimal, 2);
                    SalesBonusTextBox.Text = EmployeeBonusDecimal.ToString("C");
             }//End of if TotalMonthlySalesTextBox is Decimal with Curency allowence && TryParse TotalHoursWorkedTextBox.Text is decimal
             else {
                 ErrorMessageLabel.Text += "";
                if(!Decimal.TryParse(TotalMonthlySalesTextBox.Text, System.Globalization.NumberStyles.Currency, null, out TotalMonthlySalesValueDecimal)){
                    if (!TotalMonthlySalesErrorBool)
                    {
                        TotalMonthlySalesErrorBool = true;
                        ErrorMessageLabel.Text += "Warning: Total Monthly Sales must be in curency and not empty.\n";
                    }//end of if !TotalMonthlySalesErrorBool
                }
                if (!Decimal.TryParse(TotalHoursWorkedTextBox.Text, out TotalHoursWorkedValueDecimal))
                {
                    if (!TotalHoursWorkedErrorBool)
                    {
                        TotalHoursWorkedErrorBool = true;
                        ErrorMessageLabel.Text += "Warning: Total Hours Worked must be in decimal format and not empty.\n";
                    }//!TotalHoursWorkedErrorBool
                }
            }//end of else
        }//end of CalculateButton_Click

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //Print the form on the print preview
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Reset the calculation for the next employee
            EmployeeNameTextBox.Text = "";
            EmployeeIdTextBox.Text = "";
            TotalHoursWorkedTextBox.Text = "";
            SalesBonusTextBox.Text = "";
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

        private void TotalMonthlySalesTextBox_Leave(object sender, EventArgs e)
        {//check data in TotalMonthlySalesTextBox is valid
            decimal checkTotalMonthlySalesValueDecimal = 0.00m;
            //Specifically alow for currency additional exceptions when trying to parse data, tryparse will return false if it can't
            //parse the string into double allowing for $.
            if (Decimal.TryParse(TotalMonthlySalesTextBox.Text, System.Globalization.NumberStyles.Currency, null, out checkTotalMonthlySalesValueDecimal))
            {
                checkTotalMonthlySalesValueDecimal = Math.Round(checkTotalMonthlySalesValueDecimal, 2);//if user entered in heypenny or lower value
                TotalMonthlySalesTextBox.Text = checkTotalMonthlySalesValueDecimal.ToString("C");
                TotalMonthlySalesErrorBool = false;
                ErrorMessageLabel.Text = (TotalHoursWorkedErrorBool)?"Warning: Total Hours Worked can only be from 0 to 160 hours \n inclusive and not empty.\n":"";
            }//end of if
            else {
                if (!TotalMonthlySalesErrorBool)
                {
                    TotalMonthlySalesErrorBool = true;
                    ErrorMessageLabel.Text += "Warning: Total Monthly Sales must be in curency and not empty.\n";
                }//end of if !TotalMonthlySalesErrorBool
            }//end of else
        }

        private void TotalHoursWorkedTextBox_Leave(object sender, EventArgs e)
        {//check data in TotalHoursWorkedTextBox is valid
            decimal checkTotalHoursWorkedValueDecimal = 0.0m;
            if (Decimal.TryParse(TotalHoursWorkedTextBox.Text, out checkTotalHoursWorkedValueDecimal))
            {
                if ((checkTotalHoursWorkedValueDecimal < 0) || (checkTotalHoursWorkedValueDecimal > 160))
                {
                    if (!TotalHoursWorkedErrorBool)
                    {
                        TotalHoursWorkedErrorBool = true;
                        ErrorMessageLabel.Text += "Warning: Total Hours Worked can only be from 0 to 160 hours \n inclusive and not empty.\n";
                    }
                }
                else
                {
                    TotalHoursWorkedErrorBool = false;
                    ErrorMessageLabel.Text = (TotalMonthlySalesErrorBool) ? "Warning: Total Monthly Sales must be in curency and not empty.\n" : "";
                }
            }//end of Decimal.tryParse if
            else {
                if (!TotalHoursWorkedErrorBool)
                {
                    TotalHoursWorkedErrorBool = true;
                    ErrorMessageLabel.Text += "Warning: Total Hours Worked can only be from 0 to 160 hours \n inclusive and not empty.\n";
                }
            }
        }//end of TotalhoursWorkedTextBox_Leave
    }
}
