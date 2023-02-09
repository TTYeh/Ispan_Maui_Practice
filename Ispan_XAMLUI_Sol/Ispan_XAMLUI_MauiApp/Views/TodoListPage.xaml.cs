namespace Ispan_XAMLUI_MauiApp.Views;

public partial class TodoListPage : ContentPage
{
	public TodoListPage()
	{
		InitializeComponent();
	}

	private void btnAdd_click(object sender, EventArgs e)
	{
        Preferences.Default.Set("T1", entryItem.Text);
        Preferences.Default.Set("D1", entryFinishedDate.Text);
    }

	private void btnReadAll_click(object sender, EventArgs e)
	{
		string result = string.Empty;
        result += Preferences.Default.Get("T1", "");
        result += Preferences.Default.Get("D1", "");
        txtReadShow.Text = result;
    }
}