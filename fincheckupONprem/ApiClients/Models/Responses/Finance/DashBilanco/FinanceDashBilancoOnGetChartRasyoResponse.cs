using fincheckup.ApiClients.Models.Requests.Finance.DashBilanco;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashBilanco
{
    public class FinanceDashBilancoOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashBilancoRequestInitialModel InitialModel { get; set; }
    }
}
