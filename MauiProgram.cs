using FinancieraAPP.Services;
using FinancieraAPP.Views;
using Microsoft.Extensions.Logging;

namespace FinancieraAPP;

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

		//builder.Services.AddSingleton<IHttpsClientHandlerService, HttpsClientHandlerService>();
		//builder.Services.AddSingleton<IRestService, RestService>();
		//builder.Services.AddSingleton<ITipoDocumentoService, TipoDocumentoService>();
		//builder.Services.AddSingleton<TipoDocumentoPage>();
		//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5065") });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
