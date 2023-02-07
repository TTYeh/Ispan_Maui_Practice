namespace Ispan_XAMLUI_MauiApp.Views;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
        App a = Application.Current as App;
        userLabel.Text = a.user;
    }

	private void OnClickedGoBack(object sender, EventArgs e)
	{
        Navigation.PopAsync();
    }
}