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
 * Selection form, Alows user to select movie and display initial price for movie of that genre
 */
namespace KevinKanAssignment3MovieBonanza
{
    public partial class SelectionForm : Form
    {
        OrderForm newOrder = new OrderForm();
        private string movieImage,movieName,movieCategory;
        private decimal cost;

        public SelectionForm()
        {
            InitializeComponent();
            
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            newOrder.PreviousForm = this;
            string passCost = cost.ToString();
            string[] passData = new string[] { movieName, movieCategory, movieImage, passCost };//name,category,image,cost

            newOrder.PassData = passData;
            this.Hide();
            newOrder.Show();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
