using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetaild;

public class DashCrmDetaildOnGetPrioRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetaildOnGetPrioQuery
{
    public DashCrmDetaildOnGetPrioRequest Request { get; set; }
}
