
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCpmNew;
public class DashCpmNewOnGetChartRasyoRequest
{
    public DashCpmNewRequest InitialModel { get; set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCpmNewOnGetChartRasyoQuery
{
    public DashCpmNewOnGetChartRasyoRequest Request { get; set; }
}
