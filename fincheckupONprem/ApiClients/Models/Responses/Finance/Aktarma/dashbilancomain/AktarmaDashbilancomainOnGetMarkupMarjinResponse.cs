using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.dashbilancomain;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Aktarma.dashbilancomain;
public class AktarmaDashbilancomainOnGetMarkupMarjinResponse
{
    public AktarmaDashbilancomainInitialModel InitialModel { get; set; }
    public JsonResult Result { get; set; }
}
