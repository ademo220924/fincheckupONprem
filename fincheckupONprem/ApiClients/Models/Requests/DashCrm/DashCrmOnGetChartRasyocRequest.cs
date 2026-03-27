
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashCrm;
public class DashCrmOnGetChartRasyocRequest
{
    public DashCrmRequest InitialModel { get; internal set; }
    public DataSourceLoadOptions Options { get; set; }
}

public class DashCrmOnGetChartRasyocQuery
{
    public DashCrmOnGetChartRasyocRequest Request { get; set; }
}
