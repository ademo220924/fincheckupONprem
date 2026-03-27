using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.CashFlow
{
    public class MizanCashFlowOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanCashFlowOnGetChartRasyoQuery
    {
        public MizanCashFlowOnGetChartRasyoRequest Request { get; set; }
    }
}
