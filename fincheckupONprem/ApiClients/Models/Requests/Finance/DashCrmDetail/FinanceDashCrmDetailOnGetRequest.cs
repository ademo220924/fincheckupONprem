
using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail
{
    public class FinanceDashCrmDetailOnGetRequest
    {
        public FinanceDashCrmDetailRequestInitialModel Request { get; set; }
    }

    public class FinanceDashCrmDetailOnGetQuery
    {
        public FinanceDashCrmDetailOnGetRequest Request { get; set; }
    }
}
