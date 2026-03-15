using Microsoft.AspNetCore.Mvc;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoMlt;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilancoMlt
{
    public class MizanDashBilancoMltOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashBilancoMltRequestInitialModel InitialModel { get; set; }
    }
}
