
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRevenue;
public class DashRevenueOnGetPrioRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashRevenueOnGetPrioQuery
{
    public DashRevenueOnGetPrioRequest Request { get; set; }
}
