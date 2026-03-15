
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRasyo;
public class DashRasyoOnGetChartLikidRequest
{
    public DashRasyoRequest InitialModel { get; set; }
    public DataSourceLoadOptions Options { get; set; }
}