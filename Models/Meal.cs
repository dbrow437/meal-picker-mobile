using System;
namespace MealPicker.Models
{
	public class Meal
	{
		public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
		public MealTypes MealType { get; set; }
	}
}

