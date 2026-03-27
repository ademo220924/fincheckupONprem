
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.upaccount;
public class UpaccountOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class UpaccountOnGetQuery
{
    public UpaccountOnGetRequest Request { get; set; }
}
