using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznOldYedek;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMznOldYedek
{
    public class MizanUploadMznOldYedekOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUploadMznOldYedekRequestInitialModel InitialModel { get; set; }
    }
}
