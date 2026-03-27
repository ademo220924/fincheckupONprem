
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrm;
public class DashCrmOnGetChartMaliRequest
{
    public DashCrmRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmOnGetChartMaliQuery
{
    public DashCrmOnGetChartMaliRequest Request { get; set; }
}
