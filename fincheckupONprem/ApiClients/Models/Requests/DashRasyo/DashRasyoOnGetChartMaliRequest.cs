
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRasyo;
public class DashRasyoOnGetChartMaliRequest
{
    public DashRasyoRequest InitialMode { get; set; }
    public DataSourceLoadOptions Options { get; set; }
}