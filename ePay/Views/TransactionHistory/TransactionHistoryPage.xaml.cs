namespace ePay.Views.TransactionHistory;

public class TransactionHistoryPage : ContentPage
{
    public TransactionHistoryPage()
    {
        Title = "Transaction History";

        var searchBar = new SearchBar { Placeholder = "Search Transactions" };
        var transactionsListView = new ListView(); // Bind the ListView to a data source containing the user's transaction history

        Content = new StackLayout
        {
            Children = { searchBar, transactionsListView },
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        };
    }
}