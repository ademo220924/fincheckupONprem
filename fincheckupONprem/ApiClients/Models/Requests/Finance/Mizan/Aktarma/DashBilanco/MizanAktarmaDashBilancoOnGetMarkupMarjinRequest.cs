using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashBilanco
{
    public class MizanAktarmaDashBilancoOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid {  get; set; }
    }

    public class MizanAktarmaDashBilancoOnGetMarkupMarjinQuery
    {
        [JsonIgnore] public  string UserId { get; set; }
        public MizanAktarmaDashBilancoOnGetMarkupMarjinRequest Request { get; set; }
        public MizanAktarmaDashBilancoRequestInitialModel InitialModel { get; set; }
    }
}
