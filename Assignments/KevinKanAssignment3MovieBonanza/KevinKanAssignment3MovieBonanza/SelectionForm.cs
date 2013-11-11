using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Schema; 
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
        //ADD xml document  
        XDocument movieListXml = XDocument.Load("../../Resources/xml/movieList.xml");
        //create order form      
        OrderForm newOrder = new OrderForm();
        //set selected var
        private string movieImage = "", movieName = "", movieCategorySelected = "",cost="";
        //set arrays of movie data
        private string[,] movieData;
        private string[] movieTitleItemList;
        private string[,] moviePricing = new string[,]{{"Comedy","1.99"},{"Drama","1.99"},
        {"Action","1.99"},{"Sci-Fi","1.99"},{"Horror","1.99"},{"Thriller","1.99"}, {"Family","1.99"}
        ,{"New Release","1.99"}};
        public SelectionForm()
        {
            InitializeComponent();

            int count = movieListXml.XPathSelectElements("//Movie").Count();

            IEnumerable<XElement> test = movieListXml.XPathSelectElements("//Name").ToArray();
            IEnumerable<XElement> movieTitles = movieListXml.XPathSelectElements("//Name").ToArray();
            IEnumerable<XElement> movieCategorys = movieListXml.XPathSelectElements("//Category").ToArray();
            IEnumerable<XElement> moviePosters = movieListXml.XPathSelectElements("//Poster").ToArray();
            //set arrays of movie data
            movieData=new string[count,3];
            movieTitleItemList = new string[count];
            int i = 0;
            foreach (var item in movieTitles)
            {
                movieData[i,0]=item.Value;
                movieTitleItemList[i]=item.Value;
                i++;
            }
            i = 0;
            foreach (var item in movieCategorys)
            {
                movieData[i, 1] = item.Value;
                i++;
            }
            i = 0;
            foreach (var item in moviePosters)
            {
                movieData[i, 2] = item.Value;
                i++;
            }
            Array.Sort(movieTitleItemList);
            MovieSelectionListBox.DataSource = movieTitleItemList;
        }//End constructor

        private void NextButton_Click(object sender, EventArgs e)
        {
            newOrder.PreviousForm = this;
            string[] passData = new string[] { movieName, movieCategorySelected, movieImage, cost };//name,category,image,cost

            newOrder.PassData = passData;
            this.Hide();
            newOrder.Show();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MovieSelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = MovieSelectionListBox.SelectedIndex;
            if (index < 0)
            {//if nothing is selected

            }
            else { //if something is selected
                //set the movie image
                Image newImage = Image.FromFile("../../Resources/noMovie.jpeg"); 
                for (int i = 0; i < movieTitleItemList.Length; i++ )
                {
                    if (movieTitleItemList[index].Equals(movieData[i, 0]))
                    {
                        newImage = Image.FromFile("../../Resources/" + movieData[i, 2]);
                        //set selected vars to pass on later
                        movieImage = movieData[i, 2];
                        movieName = movieData[i, 0];
                        movieCategorySelected =movieData[i, 1];
                        for (int j = 0; j < moviePricing.GetLength(0); j++) {
                            if (moviePricing[j, 0].Equals(movieCategorySelected)) {
                                cost = moviePricing[j, 1];
                            }
                        }
                        TitleTextBox.Text = movieName;
                        CategoryTextBox.Text = movieCategorySelected;
                        CostTextBox.Text = cost;
                    }
                }//end of for loop
                MoviePosterPictureBox.BackgroundImage =newImage;
            }//end if/else block
        }
    }
}
