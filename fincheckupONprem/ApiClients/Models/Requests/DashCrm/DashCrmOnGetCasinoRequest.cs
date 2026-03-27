
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrm;
public class DashCrmOnGetCasinoRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmOnGetCasinoQuery
{
    public DashCrmOnGetCasinoRequest Request { get; set; }
}
