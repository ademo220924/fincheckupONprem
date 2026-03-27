using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtView
{
    public class MizanFinanceHrtViewOnGetGrossProfitRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int myear { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtViewOnGetGrossProfitQuery
    {
        public MizanFinanceHrtViewOnGetGrossProfitRequest Request { get; set; }
    }
}
