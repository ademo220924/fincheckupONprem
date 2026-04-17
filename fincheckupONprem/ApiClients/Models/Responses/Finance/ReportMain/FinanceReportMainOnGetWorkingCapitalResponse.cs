using fincheckup.ApiClients.Models.Requests.Finance.ReportMain;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.ReportMain
{
    public class FinanceReportMainOnGetWorkingCapitalResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceReportMainRequestInitialModel InitialModel { get; set; }
    }
}
