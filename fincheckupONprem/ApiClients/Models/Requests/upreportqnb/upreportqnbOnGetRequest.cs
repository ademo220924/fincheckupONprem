
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.upreportqnb;
public class upreportqnbOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }

}

public class upreportqnbOnGetQuery
{
    public upreportqnbOnGetRequest Request { get; set; }
}
