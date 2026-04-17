using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtView;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtView
{
    public class FinanceFinanceHrtViewOnGetWorkingCapitalResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceFinanceHrtViewRequestInitialModel InitialModel { get; set; }
    }
}
