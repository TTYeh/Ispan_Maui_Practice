namespace Ispan_XAMLUI_MauiApp.Views;

public partial class GridDemo : ContentPage
{
    private decimal tempLeftVal ;
    private decimal tempRightVal ;
    private string tempOperater;
    public GridDemo()
	{
		InitializeComponent();
        tempLeftVal = 0;
        tempRightVal = 0;
        tempOperater = String.Empty;
    }

	private void OnButtonClicked(object sender, EventArgs e)
	{
        // ����U�Ʀr��ɰ���
        // �o��Button���
        Button b = sender as Button;
        if (b == null) return;
        // ��h����ܨϥΪ̿�J���Ʀr
        int t = Convert.ToInt32(lblResult.Text);
        if (t == 0)
            lblResult.Text = b.Text;
        else
            lblResult.Text += b.Text;
        // ���������(�@��Log)
        allInput.Text += b.Text;

    }
    private void OnOperaterClicked(object sender, EventArgs e)
    {
        // ����U�B��Ÿ��ɰ���
        // �o��Button���
        Button b = sender as Button;
        
        tempRightVal = Convert.ToDecimal(lblResult.Text);
        lblResult.Text = 0.ToString();
        // ���������(�@��Log)
        allInput.Text += b.Text;
        // �p��
        decimal result = 0;
        if (tempOperater == "+") result = tempLeftVal + tempRightVal;
        if (tempOperater == "-") result = tempLeftVal - tempRightVal;
        if (tempOperater == "x") result = tempLeftVal * tempRightVal;
        if (tempOperater == "/") result = tempLeftVal / tempRightVal;
        if (tempOperater == String.Empty) result = tempRightVal;
        tempLeftVal = result;
        lblResult.Text = result.ToString();
        leftVal.Text = tempLeftVal.ToString();      

    }

    private void OnEqualClicked(object sender, EventArgs e)
    {
        // ����U�B��Ÿ��ɰ���
        // �o��Button���
        Button b = sender as Button;

        tempRightVal = Convert.ToDecimal(lblResult.Text);
        lblResult.Text = 0.ToString();
        // ���������(�@��Log)
        allInput.Text += b.Text;
        // �p��
        decimal result = 0;
        if (tempOperater == "+") result = tempLeftVal + tempRightVal;
        if (tempOperater == "-") result = tempLeftVal - tempRightVal;
        if (tempOperater == "x") result = tempLeftVal * tempRightVal;
        if (tempOperater == "/") result = tempLeftVal / tempRightVal;
        if (tempOperater == String.Empty) result = tempRightVal;
        tempLeftVal = result;
        lblResult.Text = result.ToString();
        leftVal.Text = tempLeftVal.ToString();
    }
}