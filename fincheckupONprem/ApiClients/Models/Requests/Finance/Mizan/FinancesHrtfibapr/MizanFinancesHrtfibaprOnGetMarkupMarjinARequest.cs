using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinancesHrtfibapr
{
    public class MizanFinancesHrtfibaprOnGetMarkupMarjinARequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinancesHrtfibaprOnGetMarkupMarjinAQuery
    {
        public MizanFinancesHrtfibaprOnGetMarkupMarjinARequest Request { get; set; }
    }
}
