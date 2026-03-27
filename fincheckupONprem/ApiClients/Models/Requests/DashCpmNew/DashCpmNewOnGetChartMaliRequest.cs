
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCpmNew;
public class DashCpmNewOnGetChartMaliRequest
{
    public DashCpmNewRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCpmNewOnGetChartMaliQuery
{
    public DashCpmNewOnGetChartMaliRequest Request { get; set; }
}
