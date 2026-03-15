using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoJrnl;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.DashBilancoJrnl
{
    public class MizanDashBilancoJrnlOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashBilancoJrnlRequestInitialModel InitialModel { get; set; }
    }
}
