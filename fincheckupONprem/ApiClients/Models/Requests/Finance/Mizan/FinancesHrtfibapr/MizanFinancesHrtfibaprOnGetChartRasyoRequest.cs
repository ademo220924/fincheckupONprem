using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinancesHrtfibapr
{
    public class MizanFinancesHrtfibaprOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanFinancesHrtfibaprOnGetChartRasyoQuery
    {
        public MizanFinancesHrtfibaprOnGetChartRasyoRequest Request { get; set; }
    }
}
