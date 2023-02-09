namespace Ispan_XAMLUI_MauiApp.Views;

public partial class TodoListView : ContentPage
{
	public TodoListView()
	{
		InitializeComponent();
        App app = (App)Application.Current;
        listViewAll.ItemsSource = app.todoEleList;

    }

    private void listViewAll_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItemIndex >= 0)
        {
            App app = Application.Current as App;
            app.selectTodoIndex = e.SelectedItemIndex;
            Navigation.PopAsync();
        }
    }
}