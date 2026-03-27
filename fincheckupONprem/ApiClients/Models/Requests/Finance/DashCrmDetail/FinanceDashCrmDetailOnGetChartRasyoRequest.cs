using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail
{
    public class FinanceDashCrmDetailOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmDetailOnGetChartRasyoQuery
    {
        public FinanceDashCrmDetailOnGetChartRasyoRequest Request { get; set; }
    }
}
