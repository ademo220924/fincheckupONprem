using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.CashFlow;

public class CashFlowOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class CashFlowOnGetQuery
{
    public CashFlowOnGetRequest Request { get; set; }
}
