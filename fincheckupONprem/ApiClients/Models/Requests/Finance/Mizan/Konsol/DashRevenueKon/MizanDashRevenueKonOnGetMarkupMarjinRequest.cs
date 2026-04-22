using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashRevenueKon
{
    public class MizanDashRevenueKonOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int myear { get; set; }
        public long compid { get; set; }
    }

    public class MizanDashRevenueKonOnGetMarkupMarjinQuery
    {
        public MizanDashRevenueKonOnGetMarkupMarjinRequest Request { get; set; }
    }
}
