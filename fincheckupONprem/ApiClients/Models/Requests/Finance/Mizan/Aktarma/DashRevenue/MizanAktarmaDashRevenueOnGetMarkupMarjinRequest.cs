using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashRevenue
{
    public class MizanAktarmaDashRevenueOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options {  get; set; }
        public long compid { get; set; }
    }

    public class MizanAktarmaDashRevenueOnGetMarkupMarjinQuery
    {
        [JsonIgnore] public  string UserId { get; set; }
        public MizanAktarmaDashRevenueOnGetMarkupMarjinRequest Request { get; set; }
        public MizanAktarmaDashRevenueRequestInitialModel InitialModel { get; set; }
    }
}
