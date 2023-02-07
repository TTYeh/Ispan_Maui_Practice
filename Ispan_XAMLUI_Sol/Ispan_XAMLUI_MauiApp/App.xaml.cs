using Ispan_XAMLUI_MauiApp.Views;

namespace Ispan_XAMLUI_MauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            // MainPage = new Lotto();
            //MainPage = new UnaryQuadraticEquation();
            //MainPage = new GridDemo();
            //MainPage = new NavigationPage(new Page1());
            //MainPage = new NavigationPage(new Page2());
            //MainPage = new CustomerSystem();
            MainPage = new NavigationPage(new MainPage());
            


        }

        public string user { get; internal set; }
    }
}