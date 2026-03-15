using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashBilanco;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashBilanco
{
    public class MizanAktarmaDashBilancoOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public MizanAktarmaDashBilancoRequestInitialModel InitialModel { get; set; }
    }
}
