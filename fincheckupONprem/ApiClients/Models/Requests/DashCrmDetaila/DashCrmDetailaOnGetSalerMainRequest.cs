
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetaila;
public class DashCrmDetailaOnGetSalerMainRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailaOnGetSalerMainQuery
{
    public DashCrmDetailaOnGetSalerMainRequest Request { get; set; }
}
