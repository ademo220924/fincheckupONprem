using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizanOld;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizanOld
{
    public class MizanReportMainTestMizanOldOnGetSalerCompResponse
    {
        public JsonResult Response { get; set; }
        public MizanReportMainTestMizanOldRequestInitialModel InitialModel { get; set; }
    }
}
