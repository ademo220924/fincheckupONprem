using fincheckup.ApiClients.Models.Requests.Finance.DashRevenueJrnl;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashRevenueJrnl
{
    public class FinanceDashRevenueJrnlOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashRevenueJrnlRequestInitialModel InitialModel { get; set; }
    }
}
