using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAutoCenter
{
    public partial class CSharpAutoCenterForm : Form
    {
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
            MessageBox.Show("This application calculates the car new purchase value with several additional accessories and allows for trade in discount",
                "About the Application", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {//reset the form to cleared values
            BasePriceTextBox.Text = "";
            TradeInValueTextBox.Text = "";
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
        {
            decimal SubTotalDecimal,TaxDecimal,BasePriceDecimal,TradeInValueDecimal,AdditionalItemsDecimal,TotalDecimal,AmountDueDecimal;
            const decimal TAX_RATEDecimal = 0.13m; 
        }
    }
}
