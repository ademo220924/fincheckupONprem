using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtView
{
    public class FinanceFinanceHrtViewOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int myear {  get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtViewOnGetMarkupMarjinQuery
    {
        public FinanceFinanceHrtViewOnGetMarkupMarjinRequest Request { get; set; }
    }
}
