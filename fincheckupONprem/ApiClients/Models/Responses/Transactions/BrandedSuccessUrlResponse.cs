using fincheckup.ApiClients.Models.Common;

namespace fincheckup.ApiClients.Models.Responses.Transactions;

public class BrandedSuccessUrlResponse : ClientResponseModel
{
    public string Url { get; set; }
}