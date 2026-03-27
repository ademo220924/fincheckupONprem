using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetChartMaliRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashRasyoOnGetChartMaliQuery
    {
        public MizanDashRasyoOnGetChartMaliRequest Request { get; set; }
    }
}
