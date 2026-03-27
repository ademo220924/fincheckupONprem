
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCpmNew;
public class DashCpmNewOnGetCasinoRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCpmNewOnGetCasinoQuery
{
    public DashCpmNewOnGetCasinoRequest Request { get; set; }
}
