using fincheckup.ApiClients.Models.Requests.Finance.DashRevenueJrnl;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashRevenueJrnl
{
    public class FinanceDashRevenueJrnlOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashRevenueJrnlRequestInitialModel InitialModel { get; set; }
    }
}
