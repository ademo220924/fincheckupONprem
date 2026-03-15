using fincheckup.ApiClients.Models.Requests.Finance.DashLiquidity;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashLiquidity
{
    public class FinanceDashLiquidityOnGetResponse
    {
        public FinanceDashLiquidityRequestInitialModel InitialModel { get; set; }
        public JsonResult Response { get; set; }
    }
}
