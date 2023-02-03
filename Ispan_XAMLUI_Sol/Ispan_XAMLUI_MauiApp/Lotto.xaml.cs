namespace Ispan_XAMLUI_MauiApp;

public partial class Lotto : ContentPage
{
	public Lotto()
	{
		InitializeComponent();
	}
    private void LottoClicked(object sender, EventArgs e)
    {
        // 定義變數
        int TotalLottoNum = 49;
        int countOfWant = 6;
        // 49個號碼中，產生中獎號6個並回傳
        List<int> prizeNumber = GetRandomNumber(TotalLottoNum).Take(countOfWant).OrderBy(w => w).ToList();
        LottoBtn.Text = List2String(prizeNumber);

        // 不知名用途
        //SemanticScreenReader.Announce(LottoBtn.Text);
    }
    private string List2String(List<int> l)
    {
        // 組合字串 中間間隔,
        string joinedString = string.Join(",", l);
        return joinedString;
    }

    private List<int> GetRandomNumber(int count)
    {
        // 產生0~ count的List
        List<int> numBank = Enumerable.Range(1, count).ToList();
        // 將List每個元素隨機打亂
        return (List<int>)numBank.Shuffle();
    }
}
public static class ListExtension
{
    private static Random rng = new Random();

    public static IList<T> Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
        return list;
    }
}