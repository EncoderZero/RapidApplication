using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
/*Author Kevin Kan
 * Version Nov 10 2013
 * Stream form, Show a form to inform the user that the video is about to stream and thank them for their
 * use of this service.
 */
namespace KevinKanAssignment3MovieBonanza
{
    public partial class StreamForm : Form
    {
        private string movieMessage="";
        private decimal totalCost;

        string[] passData = new string[5];//name,category,image,cost,dvdmessage
        //SET FUNCTIONS
        //pass along data from previous form selection
        public string[] PassData
        {
            set
            {
               passData = value;
               passData[4] = "";
            }//end of set
        }//end PassData
        //END OF SET FUNCTIONS

        public StreamForm()
        {
            InitializeComponent();
           
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {//when the form is loaded or activated display thes messages
            Image newImage = (passData[2] != "") ? (Image)Properties.Resources.ResourceManager.GetObject(passData[2]) : (Image)Properties.Resources.ResourceManager.GetObject("noMovie");
            MoviePosterPictureBox.BackgroundImage = newImage;
            movieMessage = "Your Account has been billed " + passData[3]+ passData[4]+"."+Environment.NewLine + passData[0]+" will stream in about a minute.";
            MovieInfoTextBox.Text = movieMessage;
        }
    }
}
