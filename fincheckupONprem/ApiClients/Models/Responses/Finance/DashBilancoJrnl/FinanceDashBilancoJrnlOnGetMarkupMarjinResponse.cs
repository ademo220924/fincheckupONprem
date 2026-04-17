using fincheckup.ApiClients.Models.Requests.Finance.DashBilancoJrnl;
using fincheckup.ApiClients.Models.Requests.Finance.DashBilancoJrnl;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashBilancoJrnl
{
    public class FinanceDashBilancoJrnlOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashBilancoJrnlRequestInitialModel InitialModel { get; set; }
    }
}
