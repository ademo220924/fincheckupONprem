using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizanOld;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizanOld
{
    public class MizanReportMainTestMizanOldOnGetSalerCompResponse
    {
        public JsonElement? Response { get; set; }
        public MizanReportMainTestMizanOldRequestInitialModel InitialModel { get; set; }
    }
}
