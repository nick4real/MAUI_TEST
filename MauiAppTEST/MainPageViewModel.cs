using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppTEST
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoToNewPage() => await Shell.Current.GoToAsync(nameof(NewPage1));

        [RelayCommand]
        async Task GoBack() => await Shell.Current.GoToAsync("..");
    }
}
