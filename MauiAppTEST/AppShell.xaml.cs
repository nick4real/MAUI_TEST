namespace MauiAppTEST
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Works
            Routing.RegisterRoute($"//{nameof(MainPage)}", typeof(MainPage));
            Routing.RegisterRoute($"//{nameof(MainPage)}/{nameof(NewPage1)}", typeof(NewPage1));
            Routing.RegisterRoute($"//{nameof(NewPage1)}/{nameof(NewPage2)}/{nameof(NewPage2)}", typeof(NewPage2));

            //Does't works
            //Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            //Routing.RegisterRoute($"{nameof(MainPage)}/{nameof(NewPage1)}", typeof(NewPage1));
            //Routing.RegisterRoute($"{nameof(NewPage1)}/{nameof(NewPage2)}/{nameof(NewPage2)}", typeof(NewPage2));
        }
    }
}