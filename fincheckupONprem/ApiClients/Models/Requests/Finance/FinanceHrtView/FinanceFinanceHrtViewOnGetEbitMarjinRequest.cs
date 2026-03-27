using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtView
{
    public class FinanceFinanceHrtViewOnGetEbitMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int myear {  get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtViewOnGetEbitMarjinQuery
    {
        public FinanceFinanceHrtViewOnGetEbitMarjinRequest Request { get; set; }
    }
}
