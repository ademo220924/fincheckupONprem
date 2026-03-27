using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetaila
{
    public class FinanceDashCrmDetailaOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmDetailaOnGetChartRasyoQuery
    {
        public FinanceDashCrmDetailaOnGetChartRasyoRequest Request { get; set; }
    }
}
