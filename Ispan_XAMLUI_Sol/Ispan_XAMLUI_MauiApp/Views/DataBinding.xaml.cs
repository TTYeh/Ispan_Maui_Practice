namespace Ispan_XAMLUI_MauiApp.Views;

public partial class DataBinding : ContentPage
{
	public DataBinding()
	{
		InitializeComponent();
        // °ÊºA¨tµ²
        labelDynamic.BindingContext = slider2;
        labelDynamic.SetBinding(Label.TextProperty, "Value");
    }
}