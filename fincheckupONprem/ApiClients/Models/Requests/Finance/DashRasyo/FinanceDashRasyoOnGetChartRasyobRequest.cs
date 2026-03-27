using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashRasyo
{
    public class FinanceDashRasyoOnGetChartRasyobRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashRasyoOnGetChartRasyobQuery
    {
        public FinanceDashRasyoOnGetChartRasyobRequest Request { get; set; }
    }
}
