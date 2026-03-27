
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrm;
public class DashCrmOnGetDashRasyoRequest
{
    public DashCrmRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmOnGetDashRasyoQuery
{
    public DashCrmOnGetDashRasyoRequest Request { get; set; }
}
