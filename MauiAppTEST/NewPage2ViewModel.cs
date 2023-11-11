using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppTEST
{
    public partial class NewPage2ViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoBack() => await Shell.Current.GoToAsync("..");
    }
}
