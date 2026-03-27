
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRasyo;
public class DashRasyoOnGetChartRasyoRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public DashRasyoRequest InitialModel { get; set; }
}

public class DashRasyoOnGetChartRasyoQuery
{
    public DashRasyoOnGetChartRasyoRequest Request { get; set; }
}
