using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznOldYedek;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMznOldYedek
{
    public class MizanUploadMznOldYedekOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUploadMznOldYedekRequestInitialModel InitialModel { get; set; }
    }
}
