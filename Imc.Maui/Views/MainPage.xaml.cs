using Imc.Maui.ViewModels;

namespace Imc.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
	}
}