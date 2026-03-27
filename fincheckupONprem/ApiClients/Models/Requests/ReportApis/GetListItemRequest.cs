namespace fincheckup.ApiClients.Models.Requests.ReportApis;

public class GetListItemRequest
{
    public string UserData { get; set; }
}

public class GetListItemQuery
{
    public GetListItemRequest Request { get; set; }
}
