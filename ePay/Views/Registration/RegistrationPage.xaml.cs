using ePay.Views.Login;
using Newtonsoft.Json;
using System.Text;

namespace ePay.Views.Registration
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameEntry.Text) || string.IsNullOrEmpty(NationalIdEntry.Text) || string.IsNullOrEmpty(PhoneNumberEntry.Text))
            {
                await DisplayAlert("Error", "Please fill in all the fields.", "OK");
                return;
            }

            // Send user data to the server via a REST API
            var client = new HttpClient();
            var requestData = new
            {
                name = NameEntry.Text,
                nationalId = NationalIdEntry.Text,
                phoneNumber = PhoneNumberEntry.Text,
                password = PasswordEntry.Text
            };

            var jsonContent = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:5243/api/Registration", content);
            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Success", "Registration successful!", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                await DisplayAlert("Error", "Registration failed.", "OK");
            }
        }



    }
}
