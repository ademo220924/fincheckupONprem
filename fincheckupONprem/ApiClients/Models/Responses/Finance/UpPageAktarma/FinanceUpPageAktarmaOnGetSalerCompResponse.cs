using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarma;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarma
{
    public class FinanceUpPageAktarmaOnGetSalerCompResponse
    {
        public JsonResult Response { get; set; }
        public FinanceUpPageAktarmaRequestInitialModel InitialModel { get; set; }
    }
}
