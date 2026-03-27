using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtNeo
{
    public class MizanFinanceHrtNeoOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanFinanceHrtNeoOnGetChartRasyoQuery
    {
        public MizanFinanceHrtNeoOnGetChartRasyoRequest Request { get; set; }
    }
}
