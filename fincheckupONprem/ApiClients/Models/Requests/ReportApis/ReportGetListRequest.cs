using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.ReportApis;

public class ReportGetListRequest
{
    public DataSourceLoadOptions LoadOptions { get; set; }
    public string UserData { get; set; }
}

public class ReportGetListQuery
{
    public ReportGetListRequest Request { get; set; }
}
