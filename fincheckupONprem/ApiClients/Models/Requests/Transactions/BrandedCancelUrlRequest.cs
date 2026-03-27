using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class BrandedCancelUrlRequest : BrandedCancelRequest
{

}

public class BrandedCancelUrlQuery
{
    public BrandedCancelUrlRequest Request { get; set; }
}
