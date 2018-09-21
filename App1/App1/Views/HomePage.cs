using System;

using Xamarin.Forms;

namespace App1.Views
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            this.Title = "Select Option";
            StackLayout stackLayout = new StackLayout();
            Button button = new Button();
            button.Text = "Add Company";
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button);

            button = new Button();
            button.Text = "Get";
            button.Clicked += Button_Get_Clicked;
            stackLayout.Children.Add(button);

            Content = stackLayout;


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCompanyPage());
        }

        private async void Button_Get_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new GetAllCompaniesPage());
        }

    }
}

