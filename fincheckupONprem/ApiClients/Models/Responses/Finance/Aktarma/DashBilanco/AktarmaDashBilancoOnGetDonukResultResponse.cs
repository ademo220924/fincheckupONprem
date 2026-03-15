using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashBilanco;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashBilanco;
public class AktarmaDashBilancoOnGetDonukResultResponse
{
    public JsonResult Response { get; set; }
    public AktarmaDashBilancoInitialModel InitialModel { get; set; }
}
