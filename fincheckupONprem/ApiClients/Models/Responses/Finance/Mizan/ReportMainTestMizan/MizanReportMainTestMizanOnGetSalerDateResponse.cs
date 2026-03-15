using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizan;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizan
{
    public class MizanReportMainTestMizanOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanReportMainTestMizanRequestInitialModel InitialModel { get; set; }
    }
}
