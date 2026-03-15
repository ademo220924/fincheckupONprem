using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetCheckRepPdfResponse
    {
        public JsonResult Response { get; set; }
        public MizanUpPageAktarmaRequestInitialModel InitialModel { get; set; }
    }
}
