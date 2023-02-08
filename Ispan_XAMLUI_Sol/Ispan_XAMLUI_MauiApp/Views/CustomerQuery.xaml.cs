//using static Android.Telephony.CarrierConfigManager;

namespace Ispan_XAMLUI_MauiApp.Views;

public partial class CustomerQuery : ContentPage
{
	public CustomerQuery()
	{
		InitializeComponent();
	}

	private void btnQuery_Clicked(object sender, EventArgs e)
	{
		App app = Application.Current as App;
        app.Queryword = textQueryWord.Text;
		Navigation.PopAsync();
    }
}