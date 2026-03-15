using fincheckup.ApiClients.Models.Requests.Finance.ReportMainTest;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.ReportMainTest
{
    public class FinanceReportMainTestOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public FinanceReportMainTestRequestInitialModel InitialModel { get; set; }
    }
}
