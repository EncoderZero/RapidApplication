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
 * Selection form, Alows user to select movie
 */
namespace KevinKanAssignment3MovieBonanza
{
    public partial class SelectionForm : Form
    {
        OrderForm newOrder = new OrderForm();
        public SelectionForm()
        {
            InitializeComponent();
            
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            newOrder.ShowDialog();
            this.Hide();
        }
    }
}
