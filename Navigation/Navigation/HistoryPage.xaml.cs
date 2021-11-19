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
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SQLiteConnection conn = new SQLiteConnection(App._databaseLocation);
            //this does not necessarily always create a new table
            //if a table exists, this will not create a new table.
            conn.CreateTable<Post>();
            var posts = conn.Table<Post>().ToList();

            conn.Close();

        }
    }
}