namespace Ispan_XAMLUI_MauiApp.Views;

public partial class GridDemo : ContentPage
{
    private decimal tempLeftVal ;
    private decimal tempRightVal ;
    public GridDemo()
	{
		InitializeComponent();
        tempLeftVal = 0;
        tempRightVal = 0;

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
        // 得到暫存數字
        Button b = sender as Button;
        this.tempRightVal = Convert.ToDecimal(lblResult.Text);
        lblResult.Text = 0.ToString();
        // 得到暫存數字
        decimal result = 0;
        if (b.Text == "+") result = tempLeftVal + tempRightVal;
        if (b.Text == "-") result = tempLeftVal - tempRightVal;
        if (b.Text == "x") result = tempLeftVal * tempRightVal;
        if (b.Text == "/") result = tempLeftVal / tempRightVal;

        tempLeftVal = result;
        leftVal.Text = tempLeftVal.ToString();
        //lblResult.Text = result.ToString();
        // 顯示在屏幕上
        //Button b = sender as Button;
        //if (b == null)
        //    return;
        //int t = Convert.ToInt32(lblResult.Text);
        //if (t == 0)
        //    return;
        //else
        //    lblResult.Text += b.Text;

    }

    private void OnEqualClicked(object sender, EventArgs e)
    {
        lblResult.Text = tempLeftVal.ToString();
    }
}