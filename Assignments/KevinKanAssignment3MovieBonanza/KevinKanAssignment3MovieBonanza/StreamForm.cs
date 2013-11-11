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
 * Stream form, Show a form to inform the user that the video is about to stream and thank them for their
 * use of this service.
 */
namespace KevinKanAssignment3MovieBonanza
{
    public partial class StreamForm : Form
    {
        private string movieImage,movieName;
        private decimal totalCost;

        string[] passData = new string[5];//name,category,image,cost,dvdmessage
        //SET FUNCTIONS
        //pass along data from previous form selection
        public string[] PassData
        {
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    passData[i] = value[i];
                }
            }//end of set
        }//end PassData
        //END OF SET FUNCTIONS

        public StreamForm()
        {
            InitializeComponent();
        }
    }
}
