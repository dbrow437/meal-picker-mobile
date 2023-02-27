using System;
using MealPicker.Models;

namespace MealPicker.Interfaces
{
    public interface IMealPickerService
    {
        Task<List<Meal>> GetMeals();
        Task<Meal> GetMeal();
        Task<Meal> CreateMeal();
        Task<Meal> UpdateMeal();
        Task<Meal> DeleteMeal();
    }
}

