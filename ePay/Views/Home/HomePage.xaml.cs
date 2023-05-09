using ePay.Views.AccountManagement;

namespace ePay.Views.Home
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            Title = "Home";
        }

        private async void OnSendMoneyButtonClicked(object sender, EventArgs e)
        {
            // Implement the logic to handle the send money button click event
        }

        private async void OnViewTransactionHistoryButtonClicked(object sender, EventArgs e)
        {
            // Implement the logic to handle the view transaction history button click event
        }

        private async void OnAccountManagementButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountManagementPage());
        }
    }
}
