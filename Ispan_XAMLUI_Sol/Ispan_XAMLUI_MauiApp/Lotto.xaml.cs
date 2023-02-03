namespace Ispan_XAMLUI_MauiApp;

public partial class Lotto : ContentPage
{
	public Lotto()
	{
		InitializeComponent();
	}
    private void LottoClicked(object sender, EventArgs e)
    {

        List<int> prizeNumber = GetRandomNumber(49).Take(6).ToList();
        LottoBtn.Text = List2String(prizeNumber);
        //SemanticScreenReader.Announce(LottoBtn.Text);
    }
    private string List2String(List<int> l)
    {
        string result = string.Empty;
        foreach (var item in l)
        {
            result += item.ToString() + ", ";
        }
        return result;
    }

    private List<int> GetRandomNumber(int count)
    {
        var rdn = new Random();
        List<int> numBank = Enumerable.Range(1, count).ToList();


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