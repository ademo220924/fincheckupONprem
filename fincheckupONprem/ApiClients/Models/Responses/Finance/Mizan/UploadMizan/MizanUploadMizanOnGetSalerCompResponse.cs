using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanOnGetSalerCompResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUploadMizanRequestInitialModel InitialModel { get; set; }
    }
}
