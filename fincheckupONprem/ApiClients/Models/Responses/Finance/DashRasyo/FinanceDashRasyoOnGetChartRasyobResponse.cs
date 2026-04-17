using fincheckup.ApiClients.Models.Requests.Finance.DashRasyo;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashRasyo
{
    public class FinanceDashRasyoOnGetChartRasyobResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashRasyoRequestInitialModel InitialModel { get; set; }
    }
}
