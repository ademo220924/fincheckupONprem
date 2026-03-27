using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrt
{
    public class FinanceFinanceHrtOnGetMarkupMarjinARequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtOnGetMarkupMarjinAQuery
    {
        public FinanceFinanceHrtOnGetMarkupMarjinARequest Request { get; set; }
    }
}
