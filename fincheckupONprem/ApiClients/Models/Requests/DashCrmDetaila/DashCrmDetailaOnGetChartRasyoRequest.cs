using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetaila;

public class DashCrmDetailaOnGetChartRasyoRequest
{
    public DashCrmDetailaRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailaOnGetChartRasyoQuery
{
    public DashCrmDetailaOnGetChartRasyoRequest Request { get; set; }
}
