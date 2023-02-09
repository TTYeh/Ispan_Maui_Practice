namespace Ispan_XAMLUI_MauiApp.Views;

public partial class HttpGetData : ContentPage
{
	public HttpGetData()
	{
		InitializeComponent();
	}

	private async void getByHttp(object sender, EventArgs e)
	{
		
		HttpClient client = new HttpClient();
        Uri uri = new Uri("https://www.google.com/");
        HttpResponseMessage response = await client.GetAsync(uri);
		if (response.IsSuccessStatusCode)
		{
            string html = await response.Content.ReadAsStringAsync();
			string key = "last-three";
            int start = html.IndexOf(key) + key.Length + 2;
			showResultText.Text = "¯S§O¸¹" + html.Substring(start, 8);
            //showResultText.Text = await response.Content.ReadAsStringAsync();
        }
    }
}