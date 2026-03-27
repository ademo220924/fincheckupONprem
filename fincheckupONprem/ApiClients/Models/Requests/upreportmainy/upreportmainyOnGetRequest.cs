
using System.Text.Json.Serialization;
namespace fincheckup.ApiClients.Models.Requests.upreportmainy;
public class UpreportmainyOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class UpreportmainyOnGetQuery
{
    public UpreportmainyOnGetRequest Request { get; set; }
}
