using seeri.Data;
using seeri.ViewModels;
using Microsoft.Extensions.Logging;

namespace seeri
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
            builder.Services.AddSingleton<DatabaseContext>();
            builder.Services.AddSingleton<ProductsViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<ProductNew>();
            return builder.Build();
        }
    }
}
