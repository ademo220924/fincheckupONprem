using fincheckup.ApiClients.Models.Requests.Finance.ReportMainTestOld;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.ReportMainTestOld
{
    public class FinanceReportMainTestOldOnGetCheckRepPdfResponse
    {
        public JsonResult Response { get; set; }
        public FinanceReportMainTestOldRequestInitialModel InitialModel { get; set; }
    }
}
