using MealPicker.ViewModels;
using MealPicker.Models;
using MealPicker.Views;

namespace MealPicker;

public partial class MainPage : ContentPage
{
	public MainPage(MealsViewModel viewModel)
	{
        BindingContext = viewModel;
        InitializeComponent();
	}

    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        var meal = ((VisualElement)sender).BindingContext as Meal;

        if (meal == null)
            return;

        await Shell.Current.GoToAsync(nameof(MealDetailsPage), true, new Dictionary<string, object>
        {
            {"Meal", meal }
        });


    }
}


