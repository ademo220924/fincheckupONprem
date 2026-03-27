using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashRasyo
{
    public class FinanceDashRasyoOnGetChartMaliRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashRasyoOnGetChartMaliQuery
    {
        public FinanceDashRasyoOnGetChartMaliRequest Request { get; set; }
    }
}
