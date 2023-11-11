using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppTEST
{
    public partial class NewPage1ViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoToNewPage() => await Shell.Current.GoToAsync(nameof(NewPage2));

        [RelayCommand]
        async Task GoBack() => await Shell.Current.GoToAsync("..");
    }
}
