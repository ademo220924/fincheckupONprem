using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzn;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMzn
{
    public class MizanUploadMznOnGetSalerMainChkResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUploadMznRequestInitialModel InitialModel { get; set; }
    }
}
