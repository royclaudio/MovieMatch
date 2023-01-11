//using CommunityToolkit.Maui;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using FilmFinderXUI.DataServices;
using Microsoft.Extensions.Logging;

namespace FilmFinderXUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            //.UseMauiCommunityToolkitCore()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<IRestDataService, RestDataService>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<Recommended>();
        builder.Services.AddSingleton<Search>();
        builder.Services.AddSingleton<Profile>();



#if DEBUG
        builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}

