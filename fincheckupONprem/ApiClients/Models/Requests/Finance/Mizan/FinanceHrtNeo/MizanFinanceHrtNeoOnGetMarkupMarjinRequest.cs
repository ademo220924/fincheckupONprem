using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtNeo
{
    public class MizanFinanceHrtNeoOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtNeoOnGetMarkupMarjinQuery
    {
        public MizanFinanceHrtNeoOnGetMarkupMarjinRequest Request { get; set; }
    }
}
