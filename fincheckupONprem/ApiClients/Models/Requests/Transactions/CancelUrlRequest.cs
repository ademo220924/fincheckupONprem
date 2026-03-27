using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class CancelUrlRequest : CancelRequest
{

}

public class CancelUrlQuery
{
    public CancelUrlRequest Request { get; set; }
}
