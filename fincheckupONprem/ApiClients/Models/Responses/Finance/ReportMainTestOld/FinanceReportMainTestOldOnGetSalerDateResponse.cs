using fincheckup.ApiClients.Models.Requests.Finance.ReportMainTestOld;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.ReportMainTestOld
{
    public class FinanceReportMainTestOldOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceReportMainTestOldRequestInitialModel InitialModel { get; set; }
    }
}
