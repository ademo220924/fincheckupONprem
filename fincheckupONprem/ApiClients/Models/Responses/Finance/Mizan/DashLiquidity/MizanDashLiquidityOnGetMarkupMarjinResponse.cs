using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashLiquidity;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashLiquidity
{
    public class MizanDashLiquidityOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashLiquidityRequestInitialModel InitialModel { get; set; }
    }
}
