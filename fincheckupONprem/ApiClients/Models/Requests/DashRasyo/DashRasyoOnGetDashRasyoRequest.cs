
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRasyo;
public class DashRasyoOnGetDashRasyoRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashRasyoOnGetDashRasyoQuery
{
    public DashRasyoOnGetDashRasyoRequest Request { get; set; }
}
