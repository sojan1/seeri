using seeri.Data;
using seeri.ViewModels;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace seeri
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<DatabaseContext>();
            builder.Services.AddSingleton<EventsViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<EventsNew>();
            return builder.Build();
        }
    }
}
