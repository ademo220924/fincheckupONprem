using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilanco
{
    public class MizanDashBilancoOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashBilancoOnGetChartRasyoQuery
    {
        public MizanDashBilancoOnGetChartRasyoRequest Request { get; set; }
        public MizanDashBilancoRequestInitialModel InitialModel { get; set; }
        
        [JsonIgnore] public  string UserId { get; set; }
        
    }
}
