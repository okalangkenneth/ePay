using ePay.ViewModels;

namespace ePay.Views.Settings;

public partial class SettingsPage : ContentPage
{
    MainPageViewModel _viewModel;

    public SettingsPage()
    {
        InitializeComponent();
        _viewModel = new MainPageViewModel();
        BindingContext = _viewModel;
    }
}