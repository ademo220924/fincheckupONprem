using fincheckup.ApiClients.Models.Requests.CashFlow;
using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Responses.CashFlow;
public class OnGetResponseModel
{
    public IEnumerable<YearResult> YearResults { get; set; }
    public CashFlowRequestModel CashFlowRequestInit { get; internal set; }
}