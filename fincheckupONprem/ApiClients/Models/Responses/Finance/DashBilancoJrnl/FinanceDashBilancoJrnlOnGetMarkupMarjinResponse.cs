using fincheckup.ApiClients.Models.Requests.Finance.DashBilancoJrnl;
using fincheckup.ApiClients.Models.Requests.Finance.DashBilancoJrnl;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashBilancoJrnl
{
    public class FinanceDashBilancoJrnlOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashBilancoJrnlRequestInitialModel InitialModel { get; set; }
    }
}
