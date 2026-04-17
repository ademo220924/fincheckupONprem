using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoJrnl;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.DashBilancoJrnl
{
    public class MizanDashBilancoJrnlOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashBilancoJrnlRequestInitialModel InitialModel { get; set; }
    }
}
