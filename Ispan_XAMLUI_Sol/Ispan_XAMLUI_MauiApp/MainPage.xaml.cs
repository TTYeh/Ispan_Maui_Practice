namespace Ispan_XAMLUI_MauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            lebelTest.Text = "Hello";
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            //var a = colorLabel_1.BackgroundColor;
            //List<Color> colorLists = new List<Color>() {
            //    colorLabel_1.BackgroundColor,
            //    colorLabel_2.BackgroundColor,
            //    colorLabel_3.BackgroundColor,
            //    colorLabel_4.BackgroundColor
            //};
            //colorLabel_1.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_1.BackgroundColor).ToRgbaHex());
            //colorLabel_2.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_2.BackgroundColor).ToRgbaHex());
            //colorLabel_3.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_3.BackgroundColor).ToRgbaHex());
            //colorLabel_4.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_4.BackgroundColor).ToRgbaHex());
            Display();

        }

        private void WashCardClicked(object sender, EventArgs e)
        {
            Display();
        }
        private void Display() {
            var a = colorLabel_1.BackgroundColor;
            List<Color> colorLists = new List<Color>() {
                colorLabel_1.BackgroundColor,
                colorLabel_2.BackgroundColor,
                colorLabel_3.BackgroundColor,
                colorLabel_4.BackgroundColor
            };
            colorLabel_1.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_1.BackgroundColor).ToRgbaHex());
            colorLabel_2.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_2.BackgroundColor).ToRgbaHex());
            colorLabel_3.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_3.BackgroundColor).ToRgbaHex());
            colorLabel_4.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_4.BackgroundColor).ToRgbaHex());
        }



        private string ConvertColorStr(string input) 
        {
            if (input == "#0000FF") return "藍";
            if (input == "#FFFF00") return "黃";
            if (input == "#FF0000") return "紅";
            if (input == "#008000") return "綠";

            var a = input;

            return input;
        }

        private Color getRandomColor(List<Color> colorList, Color thisColor = null)
        {
            //List<string> colorList = new List<string>() { "Red", "Green", "Blue", "Yellow" };
            // 挑出的顏色不能重複自己
            colorList.RemoveAll(p => p == thisColor);

            Random rdm = new Random();
            var p = colorList.Count;
            int rdmGenerate = rdm.Next(0, colorList.Count);
            var result = colorList[rdmGenerate];

            // 取完值後，移除的顏色要加回來
            colorList.Add(thisColor);
            return result;

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}