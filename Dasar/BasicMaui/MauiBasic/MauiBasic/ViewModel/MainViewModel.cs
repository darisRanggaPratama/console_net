using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
// using System.ComponentModel;

namespace MauiBasic.ViewModel;

public partial class MainViewModel : ObservableObject
{
	IConnectivity connectivity;

	public MainViewModel(IConnectivity connectivity)
	{
		Items = new ObservableCollection<string>();
		this.connectivity= connectivity;
	}

	[ObservableProperty]
	ObservableCollection<string> items;

	[ObservableProperty] 
	string text;

	[RelayCommand]
	async Task Add()
	{
		if (string.IsNullOrWhiteSpace(Text))
			return;

		if (connectivity.NetworkAccess != NetworkAccess.Internet)
		{
			await Shell.Current.DisplayAlert("Oh No", "No Internet", "Ok");
			return;
		}

		Items.Add(Text);

		// Add our item
		Text = string.Empty;
	}

	[RelayCommand]
	void Delete(string s)
	{
		if (Items.Contains(s))
		{
			Items.Remove(s);
		}
	}

	[RelayCommand]
	async Task Tap(string s)
	{
		await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
	}
}

