using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtView
{
    public class FinanceFinanceHrtViewOnGetWorkingCapitalRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int myear {  get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtViewOnGetWorkingCapitalQuery
    {
        public FinanceFinanceHrtViewOnGetWorkingCapitalRequest Request { get; set; }
    }
}
