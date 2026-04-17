using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRevenue
{
    public class MizanDashRevenueOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanDashRevenueOnGetChartRasyoQuery
    {
        public MizanDashRevenueOnGetChartRasyoRequest Request { get; set; }
        public MizanDashRevenueRequestInitialMopdel InitialModel { get; set; }
        [JsonIgnore] public  string UserId { get; set; }
    }
}
