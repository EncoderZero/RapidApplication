﻿using System;
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
using System.Resources;

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
        private string movieImage = "noMovie.jpeg", movieName = "", movieCategorySelected = "", cost = "";
        //set arrays of movie data
        private string[,] movieData;
        private string[] movieTitleItemList;
        private string[,] moviePricing = new string[,]{{"Comedy","1.99"},{"Drama","1.99"},
        {"Action","2.99"},{"Sci-Fi","2.99"},{"Horror","2.99"},{"Thriller","1.99"}, {"Family","0.99"}
        ,{"New Release","4.99"}};
       
        public SelectionForm()
        {
            InitializeComponent();
            //cout number of movies
            int count = movieListXml.XPathSelectElements("//Movie").Count();
            //create arrays of each node infomration type
            IEnumerable<XElement> movieTitles = movieListXml.XPathSelectElements("//Name").ToArray();
            IEnumerable<XElement> movieCategorys = movieListXml.XPathSelectElements("//Category").ToArray();
            IEnumerable<XElement> moviePosters = movieListXml.XPathSelectElements("//Poster").ToArray();
            //set arrays of movie data, 0 is name , 1=category, 2 is poster image filename
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
            //add array to listbox
            MovieSelectionListBox.Items.AddRange(movieTitleItemList);
        }//End constructor

        private void NextButton_Click(object sender, EventArgs e)
        {//click next button
            if (MovieSelectionListBox.SelectedIndex == -1)
            {//if no movie is selected
                MessageBox.Show("Sorry, but you need to pick a movie first", "Can't stream", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {// if movie is selected 
                newOrder.PreviousForm = this;
                string[] passData = new string[] { movieName, movieCategorySelected, movieImage, cost, "" };//name,category,image,cost,dvdMessage

                newOrder.PassData = passData;
                this.Hide();
                newOrder.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MovieSelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {//if the selection changes
            int index = MovieSelectionListBox.SelectedIndex;
            if (index < 0)
            {//if nothing is selected change all values to no movie values
                Image newImage = (Image)Properties.Resources.ResourceManager.GetObject("noMovie");
                movieName = "";
                movieCategorySelected = "";
                cost = "";
            }
            else { //if something is selected
                //set the movie image
                Image newImage = (Image)Properties.Resources.ResourceManager.GetObject("noMovie");
                for (int i = 0; i < movieTitleItemList.Length; i++ )
                {
                    if (movieTitleItemList[index].Equals(movieData[i, 0]))
                    {
                        newImage = (Image)Properties.Resources.ResourceManager.GetObject(movieData[i, 2]);
                        //set selected vars to pass on later
                        movieImage = movieData[i, 2];
                        movieName = movieData[i, 0];
                        movieCategorySelected =movieData[i, 1];
                        for (int j = 0; j < moviePricing.GetLength(0); j++) {
                            if (moviePricing[j, 0].Equals(movieCategorySelected)) {
                                cost = moviePricing[j, 1];
                            }
                        }
                    }
                }//end of for loop
                MoviePosterPictureBox.BackgroundImage =newImage;
                TitleTextBox.Text = movieName;
                CategoryTextBox.Text = movieCategorySelected;
                CostTextBox.Text = cost;
            }//end if/else block
        }
    }
}
