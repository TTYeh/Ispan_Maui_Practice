namespace Ispan_XAMLUI_MauiApp.Views;

public partial class FileIO : ContentPage
{
	public FileIO()
	{
		InitializeComponent();
	}

	private void ReadButton_Clicked(object sender, EventArgs e)
	{
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(folder, "MyFile.txt");
        ReadText.Text = File.ReadAllText(path);
    }

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(folder, "MyFile.txt");
        File.WriteAllText(path, EntryText.Text);
		EntryText.Text = string.Empty;
    }
}