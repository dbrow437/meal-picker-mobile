using System;
using System.Collections.ObjectModel;
using MealPicker.Models;
using MealPicker.Interfaces;
using System.Diagnostics;

namespace MealPicker.ViewModels
{
	public class MealsViewModel : BaseViewModel
	{
        public ObservableCollection<Meal> Meals { get; } = new();
        public Command GetMealsCommand { get; }

        IMealPickerService _mealPickerService;

        public MealsViewModel(IMealPickerService mealPickerService)
        {
            Title = "Meal Picker";
            _mealPickerService = mealPickerService;
            GetMealsCommand = new Command(async () => await GetAllMeals());
        }

        public async Task GetAllMeals()
        {
            try
            {
                if (IsBusy)
                    return;

                IsBusy = true;
                var meals = await _mealPickerService.GetMeals();

                if (Meals.Count != 0)
                    Meals.Clear();

                foreach (var meal in meals)
                    Meals.Add(meal);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get recipes: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

