using fincheckup.ApiClients.Models.Requests.Finance.Upload;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Upload
{
    public class FinanceUploadMainOnGetSalerMainZetaResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceUploadMainRequestInitialModel InitialModel { get; set; }
    }
}
