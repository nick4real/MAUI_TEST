namespace MauiAppTEST;

public partial class NewPage1 : ContentPage
{
	public NewPage1(NewPage1ViewModel newPage1ViewModel)
    {
        InitializeComponent();
        BindingContext = newPage1ViewModel;
    }
}