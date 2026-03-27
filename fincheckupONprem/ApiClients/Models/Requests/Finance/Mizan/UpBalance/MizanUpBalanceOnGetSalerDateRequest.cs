using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUpBalanceOnGetSalerDateQuery
    {
        public MizanUpBalanceOnGetSalerDateRequest Request { get; set; }
    }
}
