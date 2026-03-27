using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpBalance
{
    public class FinanceUpBalanceOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpBalanceOnGetSalerCompQuery
    {
        public FinanceUpBalanceOnGetSalerCompRequest Request { get; set; }
    }
}
