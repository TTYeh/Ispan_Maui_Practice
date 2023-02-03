namespace Ispan_XAMLUI_MauiApp;

public partial class Lotto : ContentPage
{
	public Lotto()
	{
		InitializeComponent();
	}
    private void LottoClicked(object sender, EventArgs e)
    {
        // �w�q�ܼ�
        int TotalLottoNum = 49;
        int countOfWant = 6;
        // 49�Ӹ��X���A���ͤ�����6�Өæ^��
        List<int> prizeNumber = GetRandomNumber(TotalLottoNum).Take(countOfWant).OrderBy(w => w).ToList();
        LottoBtn.Text = List2String(prizeNumber);

        // �����W�γ~
        //SemanticScreenReader.Announce(LottoBtn.Text);
    }
    private string List2String(List<int> l)
    {
        // �զX�r�� �������j,
        string joinedString = string.Join(",", l);
        return joinedString;
    }

    private List<int> GetRandomNumber(int count)
    {
        // ����0~ count��List
        List<int> numBank = Enumerable.Range(1, count).ToList();
        // �NList�C�Ӥ����H������
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