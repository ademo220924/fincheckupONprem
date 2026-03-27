using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.ReportApis;

public class ReportPutOrderItemRequest
{
    [JsonIgnore] public string UserId { get; set; }
    public int Key { get; set; }
    public string Values { get; set; }
}

public class ReportPutOrderItemQuery
{
    public ReportPutOrderItemRequest Request { get; set; }
}
