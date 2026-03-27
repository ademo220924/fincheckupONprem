using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtView
{
    public class FinanceFinanceHrtViewOnGetGrossProfitRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
        public int myear { get; set; }
    }

    public class FinanceFinanceHrtViewOnGetGrossProfitQuery
    {
        public FinanceFinanceHrtViewOnGetGrossProfitRequest Request { get; set; }
    }
}
