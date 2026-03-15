using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashCrm
{
    public class MizanDashCrmOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashCrmRequestInitialModel InitialModel { get; set; }
    }
}
