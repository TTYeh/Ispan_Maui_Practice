using Ispan_XAMLUI_MauiApp.Views;

namespace Ispan_XAMLUI_MauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void onClick_GuessColor(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GuessColor());
        }

        private void onClick_Lotoo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lotto());
        }

        private void onClick_UnaryQuadraticEquation(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UnaryQuadraticEquation());
        }

        private void onClick_GridCal(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridDemo());
        }

        private void onClick_CustomerSys(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomerSystem());
        }

        private void onClick_Todolist(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TodoListPage());
        }
    }
}