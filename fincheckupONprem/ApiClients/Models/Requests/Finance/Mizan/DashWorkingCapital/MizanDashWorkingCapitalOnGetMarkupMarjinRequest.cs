using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashWorkingCapital
{
    public class MizanDashWorkingCapitalOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanDashWorkingCapitalOnGetMarkupMarjinQuery
    {
        public MizanDashWorkingCapitalOnGetMarkupMarjinRequest Request { get; set; }
    }
}
