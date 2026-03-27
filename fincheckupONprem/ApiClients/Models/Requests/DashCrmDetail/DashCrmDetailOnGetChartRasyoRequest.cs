
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetail;
public class DashCrmDetailOnGetChartRasyoRequest
{
    public DashCrmDetailRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmDetailOnGetChartRasyoQuery
{
    public DashCrmDetailOnGetChartRasyoRequest Request { get; set; }
}
