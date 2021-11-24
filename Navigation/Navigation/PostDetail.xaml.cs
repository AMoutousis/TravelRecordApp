using Navigation.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostDetail : ContentPage
    {
        Post selectedPost;

        public PostDetail(Post selectedPost)
        {
            InitializeComponent();

            //make the data available to this class
            this.selectedPost = selectedPost;

            experienceEntry.Text = selectedPost.Experience;

        }

        void UpdateButton_Clicked(object sender, System.EventArgs e)
        {
            selectedPost.Experience = experienceEntry.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                //we don't need to find the ID because we're updating the specific field and the program knows what post you're working with
                int rows = conn.Update(selectedPost);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Experience Successfully Updated", "OK");
                }
                else
                {
                    DisplayAlert("Failure", "Update Failed", "OK");
                }
            }
        }

        void DeleteButton_Clicked_1(object sender, System.EventArgs e)
        {


            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Delete(selectedPost);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Experience Successfully Deleted", "OK");
                }
                else
                {
                    DisplayAlert("Failure", "Delete Failed", "OK");
                }
            }
        }
    }
}