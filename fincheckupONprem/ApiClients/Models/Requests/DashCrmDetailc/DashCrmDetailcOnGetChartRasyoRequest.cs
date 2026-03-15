
using DevExtreme.AspNet.Mvc;
using fincheckup.ApiClients.Models.Requests.DashCrmDetailb;

namespace fincheckup.ApiClients.Models.Requests.DashCrmDetailc;
public class DashCrmDetailcOnGetChartRasyoRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public DashCrmDetailbRequest InitialModel { get; internal set; }
}