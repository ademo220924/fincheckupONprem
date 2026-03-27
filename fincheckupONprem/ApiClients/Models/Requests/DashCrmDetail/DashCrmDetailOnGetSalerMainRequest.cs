
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetail;
public class DashCrmDetailOnGetSalerMainRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailOnGetSalerMainQuery
{
    public DashCrmDetailOnGetSalerMainRequest Request { get; set; }
}
