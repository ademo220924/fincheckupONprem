using fincheckup.ApiClients.Models.Common;

namespace fincheckup.ApiClients.Models.Responses.Transactions;

public class BrandedCancelUrlResponse : ClientResponseModel
{
    public string Url { get; set; }
}