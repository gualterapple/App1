using System;
using System.IO;
using CrudCompany.Models;
using SQLite;
using Xamarin.Forms;

namespace App1.Views
{
    public class GetAllCompaniesPage : ContentPage
    {
        private ListView _listView;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myBD.db3");


        public GetAllCompaniesPage()
        {
            this.Title = "Companies";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Company>().OrderBy(x => x.Name).ToList();
            stackLayout.BackgroundColor = Color.Black;
            stackLayout.Children.Add(_listView);

            Content = stackLayout;
        }
    }
}