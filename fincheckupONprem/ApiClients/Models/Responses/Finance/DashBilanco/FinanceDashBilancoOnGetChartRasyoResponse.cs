using fincheckup.ApiClients.Models.Requests.Finance.DashBilanco;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashBilanco
{
    public class FinanceDashBilancoOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashBilancoRequestInitialModel InitialModel { get; set; }
    }
}
