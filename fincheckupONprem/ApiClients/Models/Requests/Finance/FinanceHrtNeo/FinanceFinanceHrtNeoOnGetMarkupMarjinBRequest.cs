using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtNeo
{
    public class FinanceFinanceHrtNeoOnGetMarkupMarjinBRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtNeoOnGetMarkupMarjinBQuery
    {
        public FinanceFinanceHrtNeoOnGetMarkupMarjinBRequest Request { get; set; }
    }
}
