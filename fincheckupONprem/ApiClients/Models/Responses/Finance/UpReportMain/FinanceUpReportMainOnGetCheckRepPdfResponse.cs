using fincheckup.ApiClients.Models.Requests.Finance.UpReportMain;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpReportMain
{
    public class FinanceUpReportMainOnGetCheckRepPdfResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceUpReportMainRequestInitialModel InitialModel { get; set; }
    }
}
