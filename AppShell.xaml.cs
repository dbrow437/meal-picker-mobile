using MealPicker.Views;

namespace MealPicker;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MealDetailsPage), typeof(MealDetailsPage));
	}
}

