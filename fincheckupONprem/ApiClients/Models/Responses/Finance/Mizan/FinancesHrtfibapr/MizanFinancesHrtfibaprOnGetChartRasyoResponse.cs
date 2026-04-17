using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinancesHrtfibapr;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinancesHrtfibapr
{
    public class MizanFinancesHrtfibaprOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanFinancesHrtfibaprRequestInitialModel InitialModel { get; set; }
    }
}
