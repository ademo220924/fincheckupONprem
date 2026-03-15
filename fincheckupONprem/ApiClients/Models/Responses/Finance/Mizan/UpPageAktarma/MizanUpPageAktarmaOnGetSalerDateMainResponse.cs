using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaMizan;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetSalerDateMainResponse
    {
        public JsonResult Response { get; set; }
        public MizanUpPageAktarmaMizanRequestInitialModel InitialModel { get; set; }
    }
}
