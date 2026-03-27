using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrm
{
    public class FinanceDashCrmOnGetCasinoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceDashCrmOnGetCasinoQuery
    {
        public FinanceDashCrmOnGetCasinoRequest Request { get; set; }
    }
}
