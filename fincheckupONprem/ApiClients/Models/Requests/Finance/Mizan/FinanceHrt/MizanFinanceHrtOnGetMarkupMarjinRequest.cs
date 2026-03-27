using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrt
{
    public class MizanFinanceHrtOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtOnGetMarkupMarjinQuery
    {
        public MizanFinanceHrtOnGetMarkupMarjinRequest Request { get; set; }
    }
}
