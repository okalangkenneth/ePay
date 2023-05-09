using System.Windows.Input;
using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace ePay.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            LogoutCommand = new Command(OnLogout);
        }

        public ICommand LogoutCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void OnLogout()
        {
            // Clear any user data here

            // Navigate back to the login page
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}

