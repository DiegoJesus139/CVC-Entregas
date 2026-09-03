using Microsoft.Extensions.Logging;
using CVCEntregas.Mobile.Views;

namespace CVCEntregas.Mobile;

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

        // Registro explícito das páginas
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<ListaEntregasPage>();

        return builder.Build();
    }
}