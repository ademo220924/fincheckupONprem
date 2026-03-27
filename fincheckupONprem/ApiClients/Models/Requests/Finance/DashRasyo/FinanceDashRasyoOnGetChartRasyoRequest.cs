using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashRasyo
{
    public class FinanceDashRasyoOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashRasyoOnGetChartRasyoQuery
    {
        public FinanceDashRasyoOnGetChartRasyoRequest Request { get; set; }
    }
}
