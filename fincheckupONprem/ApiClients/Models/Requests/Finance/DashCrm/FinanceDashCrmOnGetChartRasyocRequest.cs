using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartRasyocRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmOnGetChartRasyocQuery
    {
        public FinanceDashCrmOnGetChartRasyocRequest Request { get; set; }
    }
}
