using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Navigation.Model;
using SQLite;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post newPost = new Post()
            {
                Experience = experienceEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Insert(newPost);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Experience Successfully Inserted", "OK");
                }
                else
                {
                    DisplayAlert("Failure", "Experience Failed", "OK");
                }
            }


        }
    }
}