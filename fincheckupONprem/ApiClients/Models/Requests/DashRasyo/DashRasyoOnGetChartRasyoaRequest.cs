
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRasyo;
public class DashRasyoOnGetChartRasyoaRequest
{
    public DashRasyoRequest InitialModel { get; set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashRasyoOnGetChartRasyoaQuery
{
    public DashRasyoOnGetChartRasyoaRequest Request { get; set; }
}
