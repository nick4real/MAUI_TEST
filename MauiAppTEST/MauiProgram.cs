using Microsoft.Extensions.Logging;

namespace MauiAppTEST
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<NewPage1ViewModel>();
            builder.Services.AddTransient<NewPage2ViewModel>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<NewPage1>();
            builder.Services.AddTransient<NewPage2>();

            return builder.Build();
        }
    }
}