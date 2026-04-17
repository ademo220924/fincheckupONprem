using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashWorkingCapital;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashWorkingCapital
{
    public class MizanDashWorkingCapitalOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashWorkingCapitalRequestInitialModel InitialModel { get; set; }
    }
}
