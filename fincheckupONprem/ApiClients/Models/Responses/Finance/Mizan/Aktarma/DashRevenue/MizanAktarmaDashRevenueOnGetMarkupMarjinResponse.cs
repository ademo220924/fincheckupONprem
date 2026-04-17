using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashRevenue;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashRevenue
{
    public class MizanAktarmaDashRevenueOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public MizanAktarmaDashRevenueRequestInitialModel InitialModel { get; set; }
        public MizanDashRevenueRequestInitialMopdel InitialMopdel { get; set; }
    }
}
