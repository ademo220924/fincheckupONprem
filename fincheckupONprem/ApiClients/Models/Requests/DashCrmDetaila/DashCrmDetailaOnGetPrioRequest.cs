
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetaila;
public class DashCrmDetailaOnGetPrioRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailaOnGetPrioQuery
{
    public DashCrmDetailaOnGetPrioRequest Request { get; set; }
}
