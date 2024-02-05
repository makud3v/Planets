namespace PlanetsApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
				fonts.AddFont("Montserrat-Semibold.ttf", "MontserratSemibold");
                fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
            });

		return builder.Build();
	}
}
