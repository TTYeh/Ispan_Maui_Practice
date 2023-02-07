namespace Ispan_XAMLUI_MauiApp.Views;

public partial class GridDemo : ContentPage
{
	public GridDemo()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
        Button b = sender as Button;
        if (b == null)
            return;
        int t = Convert.ToInt32(lblResult.Text);
        if (t == 0)
            lblResult.Text = b.Text;
        else
            lblResult.Text += b.Text;

    }
    private void OnOperaterClicked(object sender, EventArgs e)
    {
        Button b = sender as Button;
        if (b == null)
            return;
        int t = Convert.ToInt32(lblResult.Text);
        if (t == 0)
            return;
        else
            lblResult.Text += b.Text;

    }

    private void OnEqualClicked(object sender, EventArgs e)
    {

    }
}