using Microsoft.Extensions.Logging;

namespace LinkedIn
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
                    fonts.AddFont("myriadprobold.otf", "myriadprobold");
                    fonts.AddFont("myriadprolight.otf", "myriadprolight");
                    fonts.AddFont("myriadprosemibold.otf", "myriadprosemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
