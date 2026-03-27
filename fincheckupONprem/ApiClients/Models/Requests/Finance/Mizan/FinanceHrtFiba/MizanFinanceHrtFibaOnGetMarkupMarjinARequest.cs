using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtFiba
{
    public class MizanFinanceHrtFibaOnGetMarkupMarjinARequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtFibaOnGetMarkupMarjinAQuery
    {
        public MizanFinanceHrtFibaOnGetMarkupMarjinARequest Request { get; set; }
    }
}
