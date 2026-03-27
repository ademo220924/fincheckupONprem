using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUpBalanceOnGetSalerYearQuery
    {
        public MizanUpBalanceOnGetSalerYearRequest Request { get; set; }
    }
}
