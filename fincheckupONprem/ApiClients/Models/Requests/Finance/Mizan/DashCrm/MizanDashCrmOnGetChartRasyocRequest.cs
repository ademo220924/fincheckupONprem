using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm
{
    public class MizanDashCrmOnGetChartRasyocRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashCrmOnGetChartRasyocQuery
    {
        public MizanDashCrmOnGetChartRasyocRequest Request { get; set; }
        public MizanDashCrmRequestInitialModel InitialModel { get; set; }
        [JsonIgnore] public  string UserId { get; set; }
    }
}
