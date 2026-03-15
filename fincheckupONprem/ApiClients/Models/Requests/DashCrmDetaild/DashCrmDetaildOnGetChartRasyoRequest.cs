
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetaild;
public class DashCrmDetaildOnGetChartRasyoRequest
{
    public DashCrmDetaildRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}