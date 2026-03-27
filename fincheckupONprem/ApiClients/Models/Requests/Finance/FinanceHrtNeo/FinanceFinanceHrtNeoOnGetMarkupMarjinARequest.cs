using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtNeo
{
    public class FinanceFinanceHrtNeoOnGetMarkupMarjinARequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtNeoOnGetMarkupMarjinAQuery
    {
        public FinanceFinanceHrtNeoOnGetMarkupMarjinARequest Request { get; set; }
    }
}
