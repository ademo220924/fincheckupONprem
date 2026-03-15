using fincheckup.ApiClients.Models.Requests.Finance.ReportMain;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.ReportMain
{
    public class FinanceReportMainOnGetWorkingCapitalResponse
    {
        public JsonResult Response { get; set; }
        public FinanceReportMainRequestInitialModel InitialModel { get; set; }
    }
}
