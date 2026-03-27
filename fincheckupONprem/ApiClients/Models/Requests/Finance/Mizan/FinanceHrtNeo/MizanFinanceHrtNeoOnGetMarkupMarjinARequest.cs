using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtNeo
{
    public class MizanFinanceHrtNeoOnGetMarkupMarjinARequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtNeoOnGetMarkupMarjinAQuery
    {
        public MizanFinanceHrtNeoOnGetMarkupMarjinARequest Request { get; set; }
    }
}
