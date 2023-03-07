using Microsoft.Extensions.DependencyInjection;
using ApiTest.V1.Base;


namespace ApiTest.V1;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services
            .AddSingleton<IRestLibrary, RestLibrary>()
            .AddScoped<IRestBuilder, RestBuilder>()
            .AddScoped<IRestFactory, RestFactory>();
    }
}
