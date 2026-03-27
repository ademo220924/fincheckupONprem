using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrt
{
    public class MizanFinanceHrtOnGetMarkupMarjinBRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtOnGetMarkupMarjinBQuery
    {
        public MizanFinanceHrtOnGetMarkupMarjinBRequest Request { get; set; }
    }
}
