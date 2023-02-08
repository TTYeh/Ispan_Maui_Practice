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
        // 當按下數字鍵時執行
        // 得到Button資料
        Button b = sender as Button;
        if (b == null) return;
        // 抓去並顯示使用者輸入的數字
        int t = Convert.ToInt32(lblResult.Text);
        if (t == 0)
            lblResult.Text = b.Text;
        else
            lblResult.Text += b.Text;
        // 紀錄並顯示(作為Log)
        allInput.Text += b.Text;

    }
    private void OnOperaterClicked(object sender, EventArgs e)
    {
        // 當按下運算符號時執行
        // 得到Button資料
        Button b = sender as Button;
        
        tempRightVal = Convert.ToDecimal(lblResult.Text);
        lblResult.Text = 0.ToString();
        // 紀錄並顯示(作為Log)
        allInput.Text += b.Text;
        // 計算
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
        // 當按下運算符號時執行
        // 得到Button資料
        Button b = sender as Button;

        tempRightVal = Convert.ToDecimal(lblResult.Text);
        lblResult.Text = 0.ToString();
        // 紀錄並顯示(作為Log)
        allInput.Text += b.Text;
        // 計算
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