using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashWorkingCapital;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashWorkingCapital
{
    public class MizanDashWorkingCapitalOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashWorkingCapitalRequestInitialModel InitialModel { get; set; }
    }
}
