using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
    public GroceryListItemsView(GroceryListItemsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    public void ZoekbalkVerandering(Object sender, TextChangedEventArgs e)
    {
        string ZoekOpdracht = e.NewTextValue;
        Console.WriteLine($"Er wordt gezocht naar: {ZoekOpdracht}");
    }
}