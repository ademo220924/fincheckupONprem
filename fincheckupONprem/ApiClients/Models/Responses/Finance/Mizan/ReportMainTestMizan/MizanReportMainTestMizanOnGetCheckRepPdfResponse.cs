using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizan;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizan
{
    public class MizanReportMainTestMizanOnGetCheckRepPdfResponse
    {
        public JsonElement? Response { get; set; }
        public MizanReportMainTestMizanRequestInitialModel InitialModel { get; set; }
    }
}
