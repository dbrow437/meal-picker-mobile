using MealPicker.ViewModels;

namespace MealPicker;

public partial class MainPage : ContentPage
{
	public MainPage(MealsViewModel viewModel)
	{
        BindingContext = viewModel;
        InitializeComponent();
	}
}


