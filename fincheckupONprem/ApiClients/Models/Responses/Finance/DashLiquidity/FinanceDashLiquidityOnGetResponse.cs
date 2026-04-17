using fincheckup.ApiClients.Models.Requests.Finance.DashLiquidity;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashLiquidity
{
    public class FinanceDashLiquidityOnGetResponse
    {
        public FinanceDashLiquidityRequestInitialModel InitialModel { get; set; }
        public JsonElement? Response { get; set; }
    }
}
