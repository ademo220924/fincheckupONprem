using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoRevenueMlt
{
    public class MizanDashBilancoRevenueMltOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public string myear {  get; set; }
        public long compid { get; set; }
    }

    public class MizanDashBilancoRevenueMltOnGetMarkupMarjinQuery
    {
        public MizanDashBilancoRevenueMltOnGetMarkupMarjinRequest Request { get; set; }
    }
}
