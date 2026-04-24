using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashLiquidity
{
    public class MizanDashLiquidityOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanDashLiquidityOnGetMarkupMarjinQuery
    {
        [JsonIgnore] public  string UserId { get; set; }
        public MizanDashLiquidityOnGetMarkupMarjinRequest Request { get; set; }
        public MizanDashLiquidityRequestInitialModel InitialModel { get; set; }
    }
}
