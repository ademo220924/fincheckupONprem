using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class BrandedSuccessUrlRequest : BrandedSuccessRequest
{

}

public class BrandedSuccessUrlQuery
{
    public BrandedSuccessUrlRequest Request { get; set; }
}
