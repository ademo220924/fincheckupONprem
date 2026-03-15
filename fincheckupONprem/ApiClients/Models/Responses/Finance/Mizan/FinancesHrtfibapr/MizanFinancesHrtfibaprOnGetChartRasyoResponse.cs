using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinancesHrtfibapr;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinancesHrtfibapr
{
    public class MizanFinancesHrtfibaprOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public MizanFinancesHrtfibaprRequestInitialModel InitialModel { get; set; }
    }
}
