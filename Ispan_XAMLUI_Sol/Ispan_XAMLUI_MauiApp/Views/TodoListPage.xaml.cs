using Ispan_XAMLUI_MauiApp.Models;

namespace Ispan_XAMLUI_MauiApp.Views;

public partial class TodoListPage : ContentPage
{
    private int currentSN;
	public TodoListPage()
	{
		InitializeComponent();
	}

	private void btnAdd_click(object sender, EventArgs e)
	{
        // add Item in Preference
		int sn = 0;
        if (Preferences.Default.ContainsKey("SN_Count"))
            sn = Preferences.Default.Get("SN_Count", 0);
        sn++;
        Preferences.Default.Set("SN_Count", sn);
        Preferences.Default.Set("T1" + sn.ToString(), entryItem.Text);
        Preferences.Default.Set("D1" + sn.ToString(), entryFinishedDate.Text);
        entryItem.Text = string.Empty;
        entryFinishedDate.Text = string.Empty;
    }

	private void btnReadAll_click(object sender, EventArgs e)
	{
        List<TodoElement> todoEleList = new List<TodoElement>();
        int sn = 0;
        if (Preferences.Default.ContainsKey("SN_Count"))
            sn = Preferences.Default.Get("SN_Count", 0);
        if (sn == 0) return;

        // 目前沒有防呆機制，如果沒有資料，會出現錯誤
        for (int i = 1; i <= sn; i++)
        {
            TodoElement todo = new TodoElement();
            todo.Item = Preferences.Default.Get("T1" + i.ToString(), "沒有資料");
            todo.FinishedDate = Preferences.Default.Get("D1" + i.ToString(), "沒有資料");
            todoEleList.Add(todo);
        }
        App app = (App)Application.Current;
        app.todoEleList = todoEleList;
        Navigation.PushAsync(new TodoListView());
    }
    protected override void OnAppearing()
    {
        // 回傳顯示時抓資料
        base.OnAppearing();
        App app = Application.Current as App;
        if (app.selectTodoIndex >= 0)
        {
            currentSN = app.selectTodoIndex - 1;
            // Display
            TodoElement todo = new TodoElement();
            todo.Item = Preferences.Default.Get("T1" + currentSN.ToString(), "沒有資料");
            todo.FinishedDate = Preferences.Default.Get("D1" + currentSN.ToString(), "沒有資料");
            txtReadShow.Text = "您選擇的資料是: "+ todo.Item + " " + todo.FinishedDate;
        }
    }
}