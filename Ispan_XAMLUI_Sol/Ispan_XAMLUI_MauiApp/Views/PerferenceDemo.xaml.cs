namespace Ispan_XAMLUI_MauiApp.Views;

public partial class PerferenceDemo : ContentPage
{
	public PerferenceDemo()
	{
		InitializeComponent();
	}



	private void btnReadAll_click(object sender, EventArgs e)
	{
        Preferences.Default.Set("T1", entryItem.Text);
        Preferences.Default.Set("D1", entryFinishedDate.Text);
    }

	private void btnAdd_click(object sender, EventArgs e)
	{
        txtReadShow.Text = Preferences.Default.Get("KK", "沒有資料");
    }
}