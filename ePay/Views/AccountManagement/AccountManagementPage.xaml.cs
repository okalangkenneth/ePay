namespace ePay.Views.AccountManagement;

public partial class AccountManagementPage : ContentPage
{
    public AccountManagementPage()
    {
        InitializeComponent();
        Title = "Account Management";
    }

    private async void OnChangePasswordButtonClicked(object sender, EventArgs e)
    {
        // Implement the logic to handle the submit button click event
        await Navigation.PushAsync(new ChangePasswordPage());
    }
}
