using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartMaliRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmOnGetChartMaliQuery
    {
        public FinanceDashCrmOnGetChartMaliRequest Request { get; set; }
    }
}
