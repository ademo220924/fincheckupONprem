
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCpmNew;
public class DashCpmNewOnGetChartRasyobRequest
{
    public DashCpmNewRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCpmNewOnGetChartRasyobQuery
{
    public DashCpmNewOnGetChartRasyobRequest Request { get; set; }
}
