namespace MauiAppTEST;

public partial class NewPage2 : ContentPage
{
	public NewPage2(NewPage2ViewModel newPage2ViewModel)
	{
		InitializeComponent();
		BindingContext = newPage2ViewModel;
	}
}