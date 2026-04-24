using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm
{
    public class MizanDashCrmOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashCrmOnGetChartRasyoQuery
    {
        public MizanDashCrmOnGetChartRasyoRequest Request { get; set; }
        public MizanDashCrmRequestInitialModel InitialModel { get; set; }
        [JsonIgnore] public  string UserId { get; set; }
    }
}
