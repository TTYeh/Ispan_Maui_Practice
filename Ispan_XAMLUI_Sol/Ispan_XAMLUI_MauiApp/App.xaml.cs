using Ispan_XAMLUI_MauiApp.Models;
using Ispan_XAMLUI_MauiApp.Views;

namespace Ispan_XAMLUI_MauiApp
{
    public partial class App : Application
    {
        public string user { get; internal set; }
        public string Queryword { get; internal set; }
        public int selectIndex { get; set; }
        public List<CCustomer> customerList { get; internal set; }
        public List<TodoElement> todoEleList { get; internal set; }
        
        public int selectTodoIndex { get; set; }

        public TodoElement selectTodoElement { get; set; }
        public App()
        {
            InitializeComponent();
            // 測試用路徑
            //MainPage = new AppShell();
            // MainPage = new Lotto();
            //MainPage = new UnaryQuadraticEquation();
            //MainPage = new GridDemo();
            //MainPage = new NavigationPage(new Page1());
            //MainPage = new NavigationPage(new Page2());
            //MainPage = new CustomerSystem();
            //MainPage = new NavigationPage(new CustomerSystem());
            //MainPage = new DataBinding();
            //MainPage = new NavigationPage(new TodoListPage());
            //MainPage = new NavigationPage(new FileIO());
            MainPage = new NavigationPage(new HttpGetData());            
            // 正是路徑
            //MainPage = new NavigationPage(new MainPage());

            // 初始化APP的資料
            selectIndex = -1; // 選擇的項目是空的
        }


    }
}