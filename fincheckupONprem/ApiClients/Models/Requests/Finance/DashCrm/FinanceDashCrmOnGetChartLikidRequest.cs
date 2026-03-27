using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartLikidRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmOnGetChartLikidQuery
    {
        public FinanceDashCrmOnGetChartLikidRequest Request { get; set; }
    }
}
