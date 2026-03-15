
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRasyo;
public class DashRasyoOnGetChartRasyoaRequest
{
    public DashRasyoRequest InitialModel { get; set; }
    public DataSourceLoadOptions Options { get; set; }
}