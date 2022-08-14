namespace MyRecipiesApp;

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
                fonts.AddFont("Quicksand-Bold.ttf", "QuickSandBold");
                fonts.AddFont("Quicksand-Light.ttf", "QuickSandLight");
                fonts.AddFont("Quicksand-Regular.ttf", "QuickSandRegular");
                fonts.AddFont("antipasto.demibold.ttf", "AntipastoDemibold");
                fonts.AddFont("antipasto.regular.ttf", "AntipastoRegular");
                fonts.AddFont("antipasto.medium.ttf", "AntipastoMedium");
                fonts.AddFont("materialdesignicons-webfont.ttf", "MaterialDesignIcons");

            });


        return builder.Build();
    }
}
