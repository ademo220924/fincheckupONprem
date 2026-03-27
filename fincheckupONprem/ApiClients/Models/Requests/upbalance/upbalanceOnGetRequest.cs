
using System.Text.Json.Serialization;
namespace fincheckup.ApiClients.Models.Requests.upbalance;
public class UpbalanceOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class UpbalanceOnGetQuery
{
    public UpbalanceOnGetRequest Request { get; set; }
}
