using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm
{
    public class MizanDashCrmOnGetChartRasyoaRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashCrmOnGetChartRasyoaQuery
    {
        public MizanDashCrmOnGetChartRasyoaRequest Request { get; set; }
        public MizanDashCrmRequestInitialModel InitialModel { get; set; }
        [JsonIgnore] public  string UserId { get; set; }
    }
}
