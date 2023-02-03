using Java.Lang;

namespace Lottery
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LottoClicked(object sender, EventArgs e)
        {
            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            List<int> prizeNumber = GetRandomNumber(49).Take(6);
            LottoBtn.Text = List2String(prizeNumber);
            //SemanticScreenReader.Announce(LottoBtn.Text);
        }
        private string List2String(List<int> l)
        {
            string result = string.Empty;
            foreach (var item in l)
            { 
                result += item.ToString();
            }
            return result;
        }

        private List<int> GetRandomNumber(int count) {
            var rdn = new Random();
            List<int> numBank = Enumerable.Range(0, count).ToList();


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
}