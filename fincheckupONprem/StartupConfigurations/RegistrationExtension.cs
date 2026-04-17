using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json;
using fincheckup.ApiClients.Services.Base;
using Refit;

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

        // ASP.NET Core API varsayılanı camelCase JSON; System.Text.Json varsayılanı büyük/küçük harfe duyarlıdır.
        // Eşleşmeyen property'ler (initialModel vs InitialModel vb.) deserialize edilmez → UI'da null görünür.
        var refitSettings = new RefitSettings
        {
            ContentSerializer = new SystemTextJsonContentSerializer(
                new JsonSerializerOptions(JsonSerializerDefaults.Web)),
        };

        foreach (var apiInterface in interfaces)
        {
                services.AddRefitClient(apiInterface, refitSettings)
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
