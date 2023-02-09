namespace Ispan_XAMLUI_MauiApp.Views;

public partial class TodoListView : ContentPage
{
	public TodoListView()
	{
		InitializeComponent();
        App app = (App)Application.Current;
        listViewAll.ItemsSource = app.todoEleList;

    }
}