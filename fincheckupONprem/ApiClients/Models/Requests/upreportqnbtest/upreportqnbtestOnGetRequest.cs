
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.upreportqnbtest;
public class upreportqnbtestOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class upreportqnbtestOnGetQuery
{
    public upreportqnbtestOnGetRequest Request { get; set; }
}
