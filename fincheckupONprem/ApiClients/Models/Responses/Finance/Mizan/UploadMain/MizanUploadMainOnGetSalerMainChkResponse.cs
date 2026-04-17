using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMain
{
    public class MizanUploadMainOnGetSalerMainChkResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUploadMainRequestInitialModel InitialModel { get; set; }
    }
}
