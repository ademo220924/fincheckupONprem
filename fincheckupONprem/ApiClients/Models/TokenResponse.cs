using fincheckup.ApiClients.Models.Common;

namespace fincheckup.ApiClients.Models;

public class TokenResponse : ClientResponseModel
{
    public string token { get; set; }
    public string is_3d { get; set; }
}
