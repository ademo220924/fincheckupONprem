
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.upcmconsole;
public class upcmconsoleOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class upcmconsoleOnGetQuery
{
    public upcmconsoleOnGetRequest Request { get; set; }
}
