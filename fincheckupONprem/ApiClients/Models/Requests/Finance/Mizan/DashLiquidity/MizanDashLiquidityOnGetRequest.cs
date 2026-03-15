
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashLiquidity
{
    public class MizanDashLiquidityOnGetRequest
    {
        [JsonIgnore] public string UserId { get; set; }
       
    }
}
