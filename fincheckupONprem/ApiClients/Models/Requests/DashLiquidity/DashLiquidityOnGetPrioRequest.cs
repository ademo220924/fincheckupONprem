
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashLiquidity;
public class DashLiquidityOnGetPrioRequest
{
    public DataSourceLoadOptions options { get; set; }
}

public class DashLiquidityOnGetPrioQuery
{
    public DashLiquidityOnGetPrioRequest Request { get; set; }
}
