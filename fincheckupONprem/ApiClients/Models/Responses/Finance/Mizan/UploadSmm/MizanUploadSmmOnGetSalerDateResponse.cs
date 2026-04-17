using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadSmm;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadSmm
{
    public class MizanUploadSmmOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUploadSmmRequestInitialModel InitialModel { get; set; }
    }
}
