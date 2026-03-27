namespace fincheckup.ApiClients.Models.Requests.ReportApis;

public class GetListOrderItemRequest
{
    public string UserData { get; set; }
}

public class GetListOrderItemQuery
{
    public GetListOrderItemRequest Request { get; set; }
}
