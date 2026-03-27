
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetail;
public class DashCrmDetailOnGetPrioRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailOnGetPrioQuery
{
    public DashCrmDetailOnGetPrioRequest Request { get; set; }
}
