using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartRasyobRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmOnGetChartRasyobQuery
    {
        public FinanceDashCrmOnGetChartRasyobRequest Request { get; set; }
    }
}
