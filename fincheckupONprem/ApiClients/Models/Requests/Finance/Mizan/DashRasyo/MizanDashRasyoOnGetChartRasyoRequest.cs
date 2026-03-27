using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashRasyoOnGetChartRasyoQuery
    {
        public MizanDashRasyoOnGetChartRasyoRequest Request { get; set; }
    }
}
