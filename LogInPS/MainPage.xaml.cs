using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace LogInPS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //This method takes user to PSN passoword reset when clicked
        protected void GoSony(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://id.sonyentertainmentnetwork.com/id/reset_password/?request_locale=en_US#/reset_password/change?entry=%2Freset_password"));
        }
        //This method will validate email address, password when Log in button is clicked
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Saves email address to validate
            var email = EmailEntry.Text;
            var pass = Passowrd.Text;
            //Regular expression
            var emailPattern =
               @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
             + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			   [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			   [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
             + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                //Shows alert if email address and password are empty
                await DisplayAlert("Alert", "Please enter email address and password", "ok");
            }

            else if (Regex.IsMatch(email, emailPattern))
            {   //This shows welcome to the user and shows email address
                await DisplayAlert("Alert", $"Welcome to PlayStation Network!" + $" " + $"{email}", "OK");
                //NavigationPage nav = new NavigationPage(new Page2() { Title = "After Login" }); This should take me to
                //ContentPage 2 after user if logged
            }
            else
            {
                await DisplayAlert("Alert", "Please check your email address and password", "OK");
                //This shows an alert message for the user to enter valid information on email and password
            }



        }
    }
}
