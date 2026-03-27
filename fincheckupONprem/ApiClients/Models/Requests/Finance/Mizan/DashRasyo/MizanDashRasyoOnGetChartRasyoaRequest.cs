using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetChartRasyoaRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanDashRasyoOnGetChartRasyoaQuery
    {
        public MizanDashRasyoOnGetChartRasyoaRequest Request { get; set; }
    }
}
