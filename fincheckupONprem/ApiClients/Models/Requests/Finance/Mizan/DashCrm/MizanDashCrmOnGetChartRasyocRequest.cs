using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm
{
    public class MizanDashCrmOnGetChartRasyocRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashCrmOnGetChartRasyocQuery
    {
        public MizanDashCrmOnGetChartRasyocRequest Request { get; set; }
    }
}
