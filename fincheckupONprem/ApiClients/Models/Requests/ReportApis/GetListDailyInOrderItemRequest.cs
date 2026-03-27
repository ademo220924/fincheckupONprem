namespace fincheckup.ApiClients.Models.Requests.ReportApis;

public class GetListDailyInOrderItemRequest
{
    public string UserData { get; set; }
}

public class GetListDailyInOrderItemQuery
{
    public GetListDailyInOrderItemRequest Request { get; set; }
}
