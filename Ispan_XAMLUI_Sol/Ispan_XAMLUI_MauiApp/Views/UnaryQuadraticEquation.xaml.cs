namespace Ispan_XAMLUI_MauiApp;

public partial class UnaryQuadraticEquation : ContentPage
{
	public UnaryQuadraticEquation()
	{
		InitializeComponent();
	}
    private void btnOk_Clicked(object sender, EventArgs e)
    {
        double a = Convert.ToDouble(txtA.Text);
        double b = Convert.ToDouble(txtB.Text);
        double c = Convert.ToDouble(txtC.Text);
        double r = b * b - 4 * a * c;
        r = Math.Sqrt(r);
        lblAns.Text = "X=" + ((-b + r) / (2 * a)).ToString("0.0#") +
            " OR X=" + ((-b - r) / (2 * a)).ToString("0.0#");
    }
}