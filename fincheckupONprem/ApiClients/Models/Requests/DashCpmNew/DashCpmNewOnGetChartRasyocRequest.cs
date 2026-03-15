
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCpmNew;
public class DashCpmNewOnGetChartRasyocRequest
{

    public DashCpmNewRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}