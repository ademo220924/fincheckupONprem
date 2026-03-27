using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtHor
{
    public class FinanceFinanceHrtHorOnGetMarkupMarjinARequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtHorOnGetMarkupMarjinAQuery
    {
        public FinanceFinanceHrtHorOnGetMarkupMarjinARequest Request { get; set; }
    }
}
