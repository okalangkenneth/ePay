namespace ePay.Views.AccountManagement;

public partial class ChangePasswordPage : ContentPage
{
    public ChangePasswordPage()
    {
        InitializeComponent();
    }

    private async void OnChangePasswordButtonClicked(object sender, EventArgs e)
    {
        // Validate user input
        if (string.IsNullOrWhiteSpace(OldPasswordEntry.Text) ||
            string.IsNullOrWhiteSpace(NewPasswordEntry.Text) ||
            string.IsNullOrWhiteSpace(ConfirmNewPasswordEntry.Text))
        {
            await DisplayAlert("Error", "Please fill in all fields.", "OK");
            return;
        }

        if (NewPasswordEntry.Text != ConfirmNewPasswordEntry.Text)
        {
            await DisplayAlert("Error", "New password and confirm new password do not match.", "OK");
            return;
        }

        // Implement the logic to change the user's password
        // using your authentication system/API

        // If the password change is successful, navigate back to the AccountManagementPage
        await DisplayAlert("Success", "Your password has been changed.", "OK");
        await Navigation.PopAsync();
    }
}