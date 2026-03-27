using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmOnGetChartRasyoQuery
    {
        public FinanceDashCrmOnGetChartRasyoRequest Request { get; set; }
    }
}
