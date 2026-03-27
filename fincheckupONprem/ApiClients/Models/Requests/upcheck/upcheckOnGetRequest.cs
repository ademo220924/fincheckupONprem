
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.upcheck;
public class upcheckOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class upcheckOnGetQuery
{
    public upcheckOnGetRequest Request { get; set; }
}
