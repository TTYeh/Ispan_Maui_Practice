namespace Ispan_XAMLUI_MauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new MainPage();
        }
    }
}