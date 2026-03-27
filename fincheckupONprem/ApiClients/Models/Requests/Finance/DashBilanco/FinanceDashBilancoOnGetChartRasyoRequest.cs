using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashBilanco
{
    public class FinanceDashBilancoOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashBilancoOnGetChartRasyoQuery
    {
        public FinanceDashBilancoOnGetChartRasyoRequest Request { get; set; }
    }
}
