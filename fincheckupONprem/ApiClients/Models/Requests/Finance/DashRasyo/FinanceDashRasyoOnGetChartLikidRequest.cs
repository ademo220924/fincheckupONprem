using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashRasyo
{
    public class FinanceDashRasyoOnGetChartLikidRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashRasyoOnGetChartLikidQuery
    {
        public FinanceDashRasyoOnGetChartLikidRequest Request { get; set; }
    }
}
