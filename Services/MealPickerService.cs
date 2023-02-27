using System;
using System.Text.Json;
using MealPicker.Interfaces;
using MealPicker.Models;

namespace MealPicker.Services
{
	public class MealPickerService : IMealPickerService
	{
        List<Meal> mealList = new();

		public MealPickerService()
		{
		}

        public async Task<List<Meal>> GetMeals()
        {
            if (mealList?.Count > 0)
                return mealList;

            using var stream = await FileSystem.OpenAppPackageFileAsync("mealdata.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            mealList = JsonSerializer.Deserialize<List<Meal>>(contents);

            return mealList;
        }

        public Task<Meal> GetMeal()
        {
            throw new NotImplementedException();
        }

        public Task<Meal> CreateMeal()
        {
            throw new NotImplementedException();
        }

        public Task<Meal> UpdateMeal()
        {
            throw new NotImplementedException();
        }

        public Task<Meal> DeleteMeal()
        {
            throw new NotImplementedException();
        }
        
    }
}

