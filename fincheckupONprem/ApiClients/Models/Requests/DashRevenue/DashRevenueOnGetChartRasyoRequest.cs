
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRevenue;
public class DashRevenueOnGetChartRasyoRequest
{
    public DashRevenueRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashRevenueOnGetChartRasyoQuery
{
    public DashRevenueOnGetChartRasyoRequest Request { get; set; }
}
