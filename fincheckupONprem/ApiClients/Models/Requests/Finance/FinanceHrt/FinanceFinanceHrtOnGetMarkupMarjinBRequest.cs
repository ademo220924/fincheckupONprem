using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrt
{
    public class FinanceFinanceHrtOnGetMarkupMarjinBRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtOnGetMarkupMarjinBQuery
    {
        public FinanceFinanceHrtOnGetMarkupMarjinBRequest Request { get; set; }
    }
}
