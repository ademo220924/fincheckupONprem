using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznMlt;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMznMlt
{
    public class MizanUploadMznMltOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUploadMznMltRequestInitialModel InitialModel { get; set; }
    }
}
