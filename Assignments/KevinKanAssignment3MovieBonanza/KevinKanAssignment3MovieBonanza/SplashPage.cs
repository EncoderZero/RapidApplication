using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinKanAssignment3MovieBonanza
{
    public partial class KKSplashPAge : Form
    {
        public KKSplashPAge()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {//Close the Splash form
            this.Close();
        }
    }
}
