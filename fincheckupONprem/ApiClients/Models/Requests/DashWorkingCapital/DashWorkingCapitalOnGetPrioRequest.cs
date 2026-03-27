
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashWorkingCapital;
public class DashWorkingCapitalOnGetPrioRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashWorkingCapitalOnGetPrioQuery
{
    public DashWorkingCapitalOnGetPrioRequest Request { get; set; }
}
