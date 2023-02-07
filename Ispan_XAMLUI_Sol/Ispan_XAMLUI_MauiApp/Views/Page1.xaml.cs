namespace Ispan_XAMLUI_MauiApp.Views;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

	private void OnClickedGoP2(object sender, EventArgs e)
	{
        App a = Application.Current as App;
		a.user = "§Úªº¶W¤H";
        Navigation.PushAsync(new Page2());
    }
}