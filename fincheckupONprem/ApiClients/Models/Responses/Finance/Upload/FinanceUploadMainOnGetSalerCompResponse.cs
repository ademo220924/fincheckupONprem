using fincheckup.ApiClients.Models.Requests.Finance.Upload;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Upload
{
    public class FinanceUploadMainOnGetSalerCompResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceUploadMainRequestInitialModel InitialModel { get; set; }
    }
}
