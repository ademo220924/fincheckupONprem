
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetailc;
public class DashCrmDetailcOnGetSalerMainRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailcOnGetSalerMainQuery
{
    public DashCrmDetailcOnGetSalerMainRequest Request { get; set; }
}
