using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtHor
{
    public class FinanceFinanceHrtHorOnGetMarkupMarjinBRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtHorOnGetMarkupMarjinBQuery
    {
        public FinanceFinanceHrtHorOnGetMarkupMarjinBRequest Request { get; set; }
    }
}
