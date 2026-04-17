using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenue;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashRevenue
{
    public class AktarmaDashRevenueOnGetMarkupMarjinResponse
    {
        public AktarmaDashRevenueInitialModel InitialModel { get; set; }
        public JsonElement? Response { get; set; }
    }
}
