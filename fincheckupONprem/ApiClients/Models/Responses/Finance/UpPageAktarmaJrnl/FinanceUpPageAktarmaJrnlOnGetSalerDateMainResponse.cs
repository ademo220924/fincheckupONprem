using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaJrnl;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarmaJrnl
{
    public class FinanceUpPageAktarmaJrnlOnGetSalerDateMainResponse
    {
        public JsonResult Response { get; set; }
        public FinanceUpPageAktarmaJrnlRequestInitialModel InitialModel { get; set; }
    }
}
