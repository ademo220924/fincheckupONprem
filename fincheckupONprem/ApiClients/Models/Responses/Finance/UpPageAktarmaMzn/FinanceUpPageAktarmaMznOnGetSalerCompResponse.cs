using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaMzn;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarmaMzn
{
    public class FinanceUpPageAktarmaMznOnGetSalerCompResponse
    {
        public JsonResult Response { get; set; }
        public FinanceUpPageAktarmaMznRequestInitialModel InitialModel { get; set; }
    }
}
