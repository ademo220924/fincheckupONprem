using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashRasyo
{
    public class FinanceDashRasyoOnGetDashRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashRasyoOnGetDashRasyoQuery
    {
        public FinanceDashRasyoOnGetDashRasyoRequest Request { get; set; }
    }
}
