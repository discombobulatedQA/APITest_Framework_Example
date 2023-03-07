using Microsoft.Extensions.DependencyInjection;
using ApiTest.V1.Base;


namespace ApiTest.V1;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        //Added in webapplicationfactory
        services
            .AddSingleton<IRestLibrary>(new RestLibrary(new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactory<GraphQLProductApp.Startup>()))//Added here
            .AddScoped<IRestBuilder, RestBuilder>()
            .AddScoped<IRestFactory, RestFactory>();
    }
}
