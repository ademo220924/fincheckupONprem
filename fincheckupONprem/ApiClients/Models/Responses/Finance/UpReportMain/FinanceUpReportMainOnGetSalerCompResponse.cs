using fincheckup.ApiClients.Models.Requests.Finance.UpReportMain;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpReportMain
{
    public class FinanceUpReportMainOnGetSalerCompResponse
    {
        public JsonResult Response { get; set; }
        public FinanceUpReportMainRequestInitialModel InitialModel { get; set; }
    }
}
