using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzan;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMzan
{
    public class MizanUploadMzanOnGetSalerMainChkResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUploadMzanRequestInitialModel InitialModel { get; set; }
    }
}
