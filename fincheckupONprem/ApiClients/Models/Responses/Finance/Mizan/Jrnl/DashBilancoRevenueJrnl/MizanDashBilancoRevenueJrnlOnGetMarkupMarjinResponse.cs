using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoRevenueJrnl;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.DashBilancoRevenueJrnl
{
    public class MizanDashBilancoRevenueJrnlOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashBilancoRevenueJrnlRequestInitialModel InitialModel { get; set; }
    }
}
