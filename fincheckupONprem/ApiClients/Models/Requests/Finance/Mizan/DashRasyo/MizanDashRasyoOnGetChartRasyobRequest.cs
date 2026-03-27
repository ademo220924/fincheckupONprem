using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetChartRasyobRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanDashRasyoOnGetChartRasyobQuery
    {
        public MizanDashRasyoOnGetChartRasyobRequest Request { get; set; }
    }
}
