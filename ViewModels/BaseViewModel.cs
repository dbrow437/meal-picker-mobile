using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MealPicker.ViewModels
{
	public partial class BaseViewModel : ObservableObject
	{
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;
    }
}

