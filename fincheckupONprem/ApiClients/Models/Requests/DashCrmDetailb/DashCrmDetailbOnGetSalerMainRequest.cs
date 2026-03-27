
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetailb;
public class DashCrmDetailbOnGetSalerMainRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailbOnGetSalerMainQuery
{
    public DashCrmDetailbOnGetSalerMainRequest Request { get; set; }
}
