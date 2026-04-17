using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoRevenueJrnl;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.DashBilancoRevenueJrnl
{
    public class MizanDashBilancoRevenueJrnlOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashBilancoRevenueJrnlRequestInitialModel InitialModel { get; set; }
    }
}
