using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashRevenue
{
    public class FinanceDashRevenueOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashRevenueOnGetChartRasyoQuery
    {
        public FinanceDashRevenueOnGetChartRasyoRequest Request { get; set; }
    }
}
