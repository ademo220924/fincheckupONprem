
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRevenue;
public class DashRevenueOnGetSalerMainRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashRevenueOnGetSalerMainQuery
{
    public DashRevenueOnGetSalerMainRequest Request { get; set; }
}
