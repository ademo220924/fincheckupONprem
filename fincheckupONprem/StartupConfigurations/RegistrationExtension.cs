using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http.Headers;
using Refit;
using System.Reflection;
using System.Linq;
using fincheckup.ApiClients.Services;
using fincheckup.ApiClients.Services.Base;

namespace fincheckup.StartupConfigurations;

public static class RegistrationExtension
{
    public static void AddFinanceApiCLientWithRefit(this IServiceCollection services, IConfiguration configuration)
    {
        var apiCallBaseAddress = configuration.GetSection("ExternalServiceSettings:FinanceCheckUpApi:BaseAddress").Value;
        if (apiCallBaseAddress == null)
            throw new ArgumentNullException(apiCallBaseAddress);
        
        var timeOut = configuration.GetSection("ExternalServiceSettings:FinanceCheckUpApi:Timeout").Value;

        var baseInterfaceType = typeof(IApiClientBase);

        // Assembly'deki tüm interface'leri bul (IApiClientBase referans-miras alan)
        var interfaces = Assembly.GetExecutingAssembly()
                                 .GetTypes()
                                 .Where(t => t.IsInterface && t.GetInterfaces().Contains(baseInterfaceType));


        foreach (var apiInterface in interfaces)
        {
                services.AddRefitClient(apiInterface)
                    .ConfigureHttpClient(client =>
                    {
                        client.BaseAddress = new Uri(apiCallBaseAddress);
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        client.Timeout = TimeSpan.FromMilliseconds(Convert.ToInt32(timeOut));
                    })
                    .AddHttpMessageHandler<AuthenticatedHttpClientHandler>();
        }
    }
}
