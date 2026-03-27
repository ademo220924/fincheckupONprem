
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRevenueJrnl;
public class DashRevenueJrnlOnGetSalerMainRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class DashRevenueJrnlOnGetSalerMainQuery
{
    public DashRevenueJrnlOnGetSalerMainRequest Request { get; set; }
}
