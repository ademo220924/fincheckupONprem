
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetaild;
public class DashCrmDetaildOnGetSalerMainRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetaildOnGetSalerMainQuery
{
    public DashCrmDetaildOnGetSalerMainRequest Request { get; set; }
}
