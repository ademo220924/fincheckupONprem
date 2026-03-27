using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtHor
{
    public class FinanceFinanceHrtHorOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class FinanceFinanceHrtHorOnGetMarkupMarjinQuery
    {
        public FinanceFinanceHrtHorOnGetMarkupMarjinRequest Request { get; set; }
    }
}
