
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCpmNew;
public class DashCpmNewOnGetDashRasyoRequest
{
    public DashCpmNewRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCpmNewOnGetDashRasyoQuery
{
    public DashCpmNewOnGetDashRasyoRequest Request { get; set; }
}
