using Microsoft.Extensions.Logging;
/*using static Android.Provider.Contacts.Intents;*/

namespace Phoneword
{
    /*Le fichier MauiProgram.cs contient le code qui configure l’application et spécifie que la classe App doit être utilisée pour exécuter l’application.*/
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

            return builder.Build();
        }
    }
}