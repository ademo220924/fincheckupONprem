using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.CashFlow
{
    public class FinanceCashFlowOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public string myear {  get; set; }
        public long compid { get; set; }
    }
}
