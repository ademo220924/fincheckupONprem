using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpReportMain;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpReportMain
{
    public class MizanUpReportMainOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUpReportMainRequestInitialModel InitialModel { get; set; }
    }
}
