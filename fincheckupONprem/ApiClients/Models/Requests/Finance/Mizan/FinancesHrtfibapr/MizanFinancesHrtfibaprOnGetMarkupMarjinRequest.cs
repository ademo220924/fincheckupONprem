using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinancesHrtfibapr
{
    public class MizanFinancesHrtfibaprOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options {  get; set; }
        public long compid { get; set; }
    }

    public class MizanFinancesHrtfibaprOnGetMarkupMarjinQuery
    {
        public MizanFinancesHrtfibaprOnGetMarkupMarjinRequest Request { get; set; }
    }
}
