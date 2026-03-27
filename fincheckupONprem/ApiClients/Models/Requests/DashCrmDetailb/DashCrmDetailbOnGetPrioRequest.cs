
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetailb;
public class DashCrmDetailbOnGetPrioRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailbOnGetPrioQuery
{
    public DashCrmDetailbOnGetPrioRequest Request { get; set; }
}
