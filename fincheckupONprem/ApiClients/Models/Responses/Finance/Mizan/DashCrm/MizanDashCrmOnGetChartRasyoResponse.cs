using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashCrm
{
    public class MizanDashCrmOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashCrmRequestInitialModel InitialModel { get; set; }
    }
}
