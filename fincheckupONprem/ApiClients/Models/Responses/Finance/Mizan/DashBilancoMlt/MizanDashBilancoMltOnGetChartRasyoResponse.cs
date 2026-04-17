using Microsoft.AspNetCore.Mvc;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoMlt;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilancoMlt
{
    public class MizanDashBilancoMltOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashBilancoMltRequestInitialModel InitialModel { get; set; }
    }
}
