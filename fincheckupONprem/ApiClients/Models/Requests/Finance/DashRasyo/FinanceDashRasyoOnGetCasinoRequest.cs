using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashRasyo
{
    public class FinanceDashRasyoOnGetCasinoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashRasyoOnGetCasinoQuery
    {
        public FinanceDashRasyoOnGetCasinoRequest Request { get; set; }
    }
}
