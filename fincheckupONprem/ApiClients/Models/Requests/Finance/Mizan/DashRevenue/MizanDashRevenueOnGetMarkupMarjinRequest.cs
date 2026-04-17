using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRevenue
{
    public class MizanDashRevenueOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public string myear { get; set; }
        public long compid { get; set; }
    }

    public class MizanDashRevenueOnGetMarkupMarjinQuery
    {
        public MizanDashRevenueOnGetMarkupMarjinRequest Request { get; set; }
    }
}
