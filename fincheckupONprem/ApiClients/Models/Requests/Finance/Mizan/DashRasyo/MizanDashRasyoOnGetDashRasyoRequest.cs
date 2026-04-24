using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetDashRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashRasyoOnGetDashRasyoQuery
    {
        [JsonIgnore] public  string UserId { get; set; }
        public MizanDashRasyoOnGetDashRasyoRequest Request { get; set; }
        public MizanDashRasyoRequestInitialModel InitialModel { get; set; }
    }
}
