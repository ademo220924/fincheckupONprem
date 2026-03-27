
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrm;
public class DashCrmOnGetChartLikidRequest
{
    public DashCrmRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmOnGetChartLikidQuery
{
    public DashCrmOnGetChartLikidRequest Request { get; set; }
}
