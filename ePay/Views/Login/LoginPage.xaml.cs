using ePay.Views.Home;
using Microsoft.Maui.Controls;
using System;

namespace ePay.Views.Login
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Title = "Login";

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnForgotPasswordLabelTapped;
            ForgotPasswordLabel.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PhoneNumberEntry.Text) || string.IsNullOrEmpty(PasswordEntry.Text))
            {
                await DisplayAlert("Error", "Please enter your phone number and password.", "OK");
                return;
            }

            // Check the user's credentials against the stored data (local database or remote server)
            // For example, you could use SQLite for local storage or a REST API for remote storage

            bool isValidUser = true; // Set this variable based on the actual authentication result

            if (isValidUser)
            {
                // Navigate to the home page after successful login
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "Invalid phone number or password.", "OK");
            }
        }


        private async void OnForgotPasswordLabelTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PasswordResetPage());
        }
    }
}



