
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace fincheckup.ApiClients.Configurations;

public class CustomJsonHandler : DelegatingHandler
{
    private readonly JsonSerializerSettings _serializerSettings;

    public CustomJsonHandler(HttpMessageHandler innerHandler, JsonSerializerSettings serializerSettings)
        : base(innerHandler)
    {
        _serializerSettings = serializerSettings;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Content != null)
        {
            // Serialize request content using custom settings
            var jsonContent = await request.Content.ReadAsStringAsync(cancellationToken);
            var serializedContent = JsonConvert.SerializeObject(
                JsonConvert.DeserializeObject(jsonContent),
                _serializerSettings
            );
            request.Content = new StringContent(serializedContent, Encoding.UTF8, "application/json");
        }

        var response = await base.SendAsync(request, cancellationToken);

        if (response.Content != null)
        {
            // Deserialize response content using custom settings
            var jsonResponse = await response.Content.ReadAsStringAsync(cancellationToken);
            var deserializedResponse = JsonConvert.DeserializeObject(jsonResponse, _serializerSettings);
            response.Content = new StringContent(JsonConvert.SerializeObject(deserializedResponse), Encoding.UTF8, "application/json");
        }

        return response;
    }
}