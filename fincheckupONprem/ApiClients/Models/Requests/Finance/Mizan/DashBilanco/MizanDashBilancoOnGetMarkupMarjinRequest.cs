using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilanco
{
    public class MizanDashBilancoOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public string myear { get; set; }
        public long compid { get; set; }
    }

    public class MizanDashBilancoOnGetMarkupMarjinQuery
    {
        public MizanDashBilancoOnGetMarkupMarjinRequest Request { get; set; }
    }
}
