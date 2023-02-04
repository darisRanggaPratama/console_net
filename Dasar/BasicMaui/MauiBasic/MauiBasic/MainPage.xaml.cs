using MauiBasic.ViewModel;

namespace MauiBasic;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm; 
	}

	
}

