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
        public MizanAktarmaDashRevenueOnGetMarkupMarjinRequest Request { get; set; }
    }
}
