using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartRasyoaRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmOnGetChartRasyoaQuery
    {
        public FinanceDashCrmOnGetChartRasyoaRequest Request { get; set; }
    }
}
