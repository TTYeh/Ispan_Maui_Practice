namespace Ispan_XAMLUI_MauiApp.Views;

public partial class CustomerList : ContentPage
{
	public CustomerList()
	{
		InitializeComponent();
        App app = Application.Current as App;
        lvCustomer.ItemsSource = app.customerList;
    }

    private void lvCustomer_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItemIndex >= 0)
        {
            App app = Application.Current as App;
            app.selectIndex = e.SelectedItemIndex;
            Navigation.PopAsync();
        }
    }
}