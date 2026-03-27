using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrt
{
    public class FinanceFinanceHrtOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtOnGetMarkupMarjinQuery
    {
        public FinanceFinanceHrtOnGetMarkupMarjinRequest Request { get; set; }
    }
}
