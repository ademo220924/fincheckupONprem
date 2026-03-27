
namespace fincheckup.ApiClients.Models.Requests.DashLiquidity;
public class DashLiquidityOnGetGraphYearRequest
{
    public int nyear { get; set; }
}

public class DashLiquidityOnGetGraphYearQuery
{
    public DashLiquidityOnGetGraphYearRequest Request { get; set; }
}
