using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpBalance
{
    public class FinanceUpBalanceOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceUpBalanceOnGetSalerYearQuery
    {
        public FinanceUpBalanceOnGetSalerYearRequest Request { get; set; }
    }
}
