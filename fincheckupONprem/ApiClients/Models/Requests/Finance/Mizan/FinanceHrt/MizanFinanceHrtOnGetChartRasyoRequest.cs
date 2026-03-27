using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrt
{
    public class MizanFinanceHrtOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanFinanceHrtOnGetChartRasyoQuery
    {
        public MizanFinanceHrtOnGetChartRasyoRequest Request { get; set; }
    }
}
