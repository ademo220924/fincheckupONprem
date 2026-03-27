
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRasyo;
public class DashRasyoOnGetCasinoRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashRasyoOnGetCasinoQuery
{
    public DashRasyoOnGetCasinoRequest Request { get; set; }
}
