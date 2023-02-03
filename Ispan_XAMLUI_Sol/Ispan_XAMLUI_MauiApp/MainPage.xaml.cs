namespace Ispan_XAMLUI_MauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lebelTest.Text = "Hello";
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            DisplayNotSameElementColor();
        }

        private void WashCardClicked(object sender, EventArgs e)
        {
            DisplayNotSameElementColor();
        }
        private void DisplayNotSameElementColor() {

            // 取出所有的Label背景顏色表
            List<Color> colorLists = new List<Color>() {
                colorLabel_1.BackgroundColor,
                colorLabel_2.BackgroundColor,
                colorLabel_3.BackgroundColor,
                colorLabel_4.BackgroundColor
            };
            // 顏色表去除自己的本身的顏色，再隨機取一種顏色，轉成字串並回傳
            colorLabel_1.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_1.BackgroundColor).ToRgbaHex());
            colorLabel_2.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_2.BackgroundColor).ToRgbaHex());
            colorLabel_3.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_3.BackgroundColor).ToRgbaHex());
            colorLabel_4.Text = ConvertColorStr(getRandomColor(colorLists, colorLabel_4.BackgroundColor).ToRgbaHex());
        }


        private string ConvertColorStr(string input) 
        {
            // 色碼轉顏色字串
            if (input == "#0000FF") return "藍";
            if (input == "#FFFF00") return "黃";
            if (input == "#FF0000") return "紅";
            if (input == "#008000") return "綠";

            return input;
        }

        private Color getRandomColor(List<Color> colorList, Color thisColor = null)
        {
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

    }
}