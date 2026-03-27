using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpBalance
{
    public class FinanceUpBalanceOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpBalanceOnGetSalerDateQuery
    {
        public FinanceUpBalanceOnGetSalerDateRequest Request { get; set; }
    }
}
