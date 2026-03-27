using DevExtreme.AspNet.Mvc;
namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtView
{
    public class FinanceFinanceHrtViewOnGetRevenueRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
        public int myear { get; set; }
    }

    public class FinanceFinanceHrtViewOnGetRevenueQuery
    {
        public FinanceFinanceHrtViewOnGetRevenueRequest Request { get; set; }
    }
}
