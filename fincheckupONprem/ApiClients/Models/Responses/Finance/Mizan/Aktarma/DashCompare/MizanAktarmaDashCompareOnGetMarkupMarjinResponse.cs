using Microsoft.AspNetCore.Mvc;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashCompare;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashCompare
{
    public class MizanAktarmaDashCompareOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public MizanAktarmaDashCompareRequestInitialModel InitialModel { get; set; }
    }
}
