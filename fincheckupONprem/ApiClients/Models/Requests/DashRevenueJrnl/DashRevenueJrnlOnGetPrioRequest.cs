
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRevenueJrnl;
public class DashRevenueJrnlOnGetPrioRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashRevenueJrnlOnGetPrioQuery
{
    public DashRevenueJrnlOnGetPrioRequest Request { get; set; }
}
