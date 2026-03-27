using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetChartLikidRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashRasyoOnGetChartLikidQuery
    {
        public MizanDashRasyoOnGetChartLikidRequest Request { get; set; }
    }
}
