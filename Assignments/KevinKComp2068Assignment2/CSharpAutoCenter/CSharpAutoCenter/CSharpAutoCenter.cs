using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Author: Kevin Kan
 * Student Number: 200213257
 * Date: Oct. 6, 2013
 * Purpose: This application calculates the car new purchase value with several additional accessories, an external finish and
 * factors in the trade in value discount. This application has the use of menus and buttons.
 */
namespace CSharpAutoCenter
{
    public partial class CSharpAutoCenterForm : Form
    {
        //var to track base price, trade in value and additional item cost total 
        decimal BasePriceDecimal, TradeInValueDecimal, AdditionalItemsDecimal;
        //constant tax rate
        const decimal TAX_RATEDecimal = 0.13m;
        //constant value for checkboxes in AdditionalOptionsGroupbox
        const decimal TRAILER_HITCH_VALUEDecimal = 242.39m, DOOR_SILL_GARNISH_VALUEDecimal = 283.83m, FOG_LIGHT_VALUEDecimal = 660.79m;
        const decimal BACKUP_SENSOR_VALUEDecimal = 834.12m;
        //Constant values for exterior finishes
        const decimal STANDARD_FINSIH_VALUE = 0.00m, PEARLED_FINSIH_VALUE = 850.00m, CUSTOM_DETAILING_FINSIH_VALUE = 1500.00m, CHROME_GOLD_FINSIH_VALUE = 2545.67m; 
        public CSharpAutoCenterForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {//Exit the form
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {//Adjust font on the AmountDueTextbox and BasePriceTextBox
            EditFontDialog.Font = AmountDueTextBox.Font; 
            EditFontDialog.ShowDialog();//open font dialog
            AmountDueTextBox.Font= EditFontDialog.Font;
            BasePriceTextBox.Font = EditFontDialog.Font;
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {//Adjust the BackColor of the AmountDueTextbox and BasePriceTextBox
            EditColorDialog.Color = AmountDueTextBox.BackColor;
            EditColorDialog.ShowDialog();//open Color dialog
            AmountDueTextBox.BackColor = EditColorDialog.Color;
            BasePriceTextBox.BackColor = EditColorDialog.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {//Show Message box that displays information on the form
            MessageBox.Show("This application calculates the car new purchase value with several additional accessories, an external finish and factors in the trade in value discount. This application has the use of menus and buttons.",
                "About the Application", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {//clear all data from form
            //set varriables to zero
            BasePriceDecimal = 0.00m;
            TradeInValueDecimal = 0.00m;
            AdditionalItemsDecimal=0.00m;
            //reset the form to initial values
            BasePriceTextBox.Text = "$0.00";
            TradeInValueTextBox.Text = "$0.00";
            AdditionalItemsTextBox.Text = "";
            SubTotalTextBox.Text="";
            TaxTextBox.Text = "";
            TotalTextBox.Text = "";
            AmountDueTextBox.Text = "";
            StandardFinishRadioButton.Checked = true;
            TrailerHitchCheckBox.Checked = false;
            FogLightCheckBox.Checked = false;
            DoorSillCheckBox.Checked = false;
            BackupSensorCheckBox.Checked = false;
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {//calculate amount due
            decimal SubTotalDecimal,TaxDecimal,TotalDecimal,AmountDueDecimal;
            SubTotalDecimal = BasePriceDecimal + AdditionalItemsDecimal;
            TaxDecimal = SubTotalDecimal * TAX_RATEDecimal;
            TotalDecimal = TaxDecimal + SubTotalDecimal;
            AmountDueDecimal=(TotalDecimal >= TradeInValueDecimal)? TotalDecimal-TradeInValueDecimal :0.0m;//ensures trade in value does not exceed base cost 
            SubTotalTextBox.Text = SubTotalDecimal.ToString("C");
            TaxTextBox.Text = TaxDecimal.ToString("C");
            TotalTextBox.Text = TotalDecimal.ToString("C");
            AmountDueTextBox.Text = AmountDueDecimal.ToString("C");
        }

        private void BasePriceTextBox_Leave(object sender, EventArgs e)
        {
            TextBox CheckLeave = (TextBox)sender;
            switch (CheckLeave.Name){
                case "BasePriceTextBox":
                    BasePriceDecimal=convertToDecimal(CheckLeave.Text, "Base Price");
                    BasePriceTextBox.Text = BasePriceDecimal.ToString("C");
                    break;
                case "TradeInValueTextBox":
                    TradeInValueDecimal=convertToDecimal(CheckLeave.Text, "Trade-In Allowance");
                    TradeInValueTextBox.Text = TradeInValueDecimal.ToString("C");
                    break;
            }//end case statement for CheckLeave.Name
            //****************************************uncomment below for dynamic price calculations*********************
            //((TradeInValueTextBox.Text!="")&&(BasePriceTextBox.Text!=""))?calculateToolStripMenuItem_Click(sender, e):NULL;
        }//end value validations

        private void TrailerHitchCheckBox_CheckedChanged(object sender, EventArgs e)
        {//if checked value is changed update additional items value
            decimal AdditionaItemsTotalDecimal = 0m;
            foreach (Control findGroupBoxes in this.Controls){//look through all controls in form (textboxes,checkboxes etc.)
                if (findGroupBoxes is GroupBox){//find all of the groupBoxes in the form
                    foreach (Control getSelectedOption in findGroupBoxes.Controls) {//parse for each element in groupbox 
                        if (getSelectedOption is CheckBox) {
                            CheckBox checkCheckBox = (CheckBox)getSelectedOption;
                            if (checkCheckBox.Checked == true) {
                                switch ((String)checkCheckBox.Name) { 
                                    case "TrailerHitchCheckBox":
                                        AdditionaItemsTotalDecimal += TRAILER_HITCH_VALUEDecimal;
                                        break;
                                    case "DoorSillCheckBox":
                                        AdditionaItemsTotalDecimal += DOOR_SILL_GARNISH_VALUEDecimal;
                                        break;
                                    case "FogLightCheckBox":
                                        AdditionaItemsTotalDecimal += FOG_LIGHT_VALUEDecimal;
                                        break;
                                    case "BackupSensorCheckBox":
                                        AdditionaItemsTotalDecimal += BACKUP_SENSOR_VALUEDecimal;
                                        break;
                                }//end case statemtent for checkboxes 
                            }//end if checkbox is checked
                        }//end if control in groupbox is checkbox
                            if (getSelectedOption is RadioButton) {
                                RadioButton checkRadioButton = (RadioButton)getSelectedOption;
                                if (checkRadioButton.Checked == true)
                                {
                                    switch ((String)checkRadioButton.Name)//case statment to check radioButton selection
                                    {
                                        case "StandardFinishRadioButton":
                                            AdditionaItemsTotalDecimal += STANDARD_FINSIH_VALUE;
                                            break;
                                        case "PearledFinishRadioButton":
                                            AdditionaItemsTotalDecimal += PEARLED_FINSIH_VALUE;
                                            break;
                                        case "CustomDetailingFinishRadioButton":
                                            AdditionaItemsTotalDecimal += CUSTOM_DETAILING_FINSIH_VALUE;
                                            break;
                                        case "ChromeGoldFinishRadioButton":
                                            AdditionaItemsTotalDecimal += CHROME_GOLD_FINSIH_VALUE;
                                            break;
                                    }//end case statement for radio buttons
                                }//end if radio button checked is true
                            }//end of if element is radio button
                    }//end of foreach element in groupBox
                }//end if control is groupBox    
            }//end of foreach control on form
            AdditionalItemsDecimal = AdditionaItemsTotalDecimal;
            AdditionalItemsTextBox.Text = AdditionaItemsTotalDecimal.ToString("C");
            //****************************************uncomment below for dynamic price calculations*********************
            //calculateToolStripMenuItem_Click(sender, e);
        }//end of TrailerHitchCheckBox_CheckedChanged

        private decimal convertToDecimal(String convertFromValue, String convertFromName) { //converts strings to decimal, handels invalid errors
            decimal returnValue;
            if (Decimal.TryParse(convertFromValue, System.Globalization.NumberStyles.Currency, null, out returnValue))
            {
                if (returnValue < 0.00m) {
                    errorMessages(convertFromName);
                    return 0.00m;
                }
                return returnValue;
            }
            else {
                errorMessages(convertFromName);
                return 0.00m;
            }
        }//end of converToDecimal function
        private void errorMessages(String errorField) {//warns user for invalid datatypes
            MessageBox.Show("The " + errorField + " value is not valid , or is less than 0. Please re-enter this field value",
                "Error Field Invalid", MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
        }//end of errorMessages Function

    }
}
