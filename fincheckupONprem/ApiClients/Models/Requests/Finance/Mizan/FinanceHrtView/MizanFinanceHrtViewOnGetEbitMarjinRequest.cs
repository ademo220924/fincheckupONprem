using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtView
{
    public class MizanFinanceHrtViewOnGetEbitMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int myear { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtViewOnGetEbitMarjinQuery
    {
        public MizanFinanceHrtViewOnGetEbitMarjinRequest Request { get; set; }
    }
}
