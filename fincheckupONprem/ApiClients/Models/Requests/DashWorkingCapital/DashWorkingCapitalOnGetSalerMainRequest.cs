
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashWorkingCapital;
public class DashWorkingCapitalOnGetSalerMainRequest
{
    public string dt1 { get; set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashWorkingCapitalOnGetSalerMainQuery
{
    public DashWorkingCapitalOnGetSalerMainRequest Request { get; set; }
}
