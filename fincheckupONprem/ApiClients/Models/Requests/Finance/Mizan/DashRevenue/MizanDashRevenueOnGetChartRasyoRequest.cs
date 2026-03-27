using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRevenue
{
    public class MizanDashRevenueOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanDashRevenueOnGetChartRasyoQuery
    {
        public MizanDashRevenueOnGetChartRasyoRequest Request { get; set; }
    }
}
