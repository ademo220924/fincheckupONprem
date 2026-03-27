
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetailc;
public class DashCrmDetailcOnGetPrioRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailcOnGetPrioQuery
{
    public DashCrmDetailcOnGetPrioRequest Request { get; set; }
}
