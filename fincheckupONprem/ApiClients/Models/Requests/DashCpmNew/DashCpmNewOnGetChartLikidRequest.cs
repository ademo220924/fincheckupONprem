
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCpmNew;
public class DashCpmNewOnGetChartLikidRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public DashCpmNewRequest InitialModel { get; internal set; }
}

public class DashCpmNewOnGetChartLikidQuery
{
    public DashCpmNewOnGetChartLikidRequest Request { get; set; }
}
