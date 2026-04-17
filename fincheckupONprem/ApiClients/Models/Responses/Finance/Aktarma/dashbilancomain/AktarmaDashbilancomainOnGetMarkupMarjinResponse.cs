using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.dashbilancomain;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Aktarma.dashbilancomain;
public class AktarmaDashbilancomainOnGetMarkupMarjinResponse
{
    public AktarmaDashbilancomainInitialModel InitialModel { get; set; }
    public JsonElement? Result { get; set; }
}
