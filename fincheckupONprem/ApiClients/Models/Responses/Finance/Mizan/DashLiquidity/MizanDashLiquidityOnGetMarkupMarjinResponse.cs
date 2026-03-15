using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashLiquidity;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashLiquidity
{
    public class MizanDashLiquidityOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashLiquidityRequestInitialModel InitialModel { get; set; }
    }
}
