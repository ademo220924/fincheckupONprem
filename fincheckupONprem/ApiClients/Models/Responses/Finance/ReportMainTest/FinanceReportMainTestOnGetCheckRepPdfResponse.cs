using fincheckup.ApiClients.Models.Requests.Finance.ReportMainTest;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.ReportMainTest
{
    public class FinanceReportMainTestOnGetCheckRepPdfResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceReportMainTestRequestInitialModel InitialModel { get; set; }
    }
}
