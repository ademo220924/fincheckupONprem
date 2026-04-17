using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpReportMain;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpReportMain
{
    public class MizanUpReportMainOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUpReportMainRequestInitialModel InitialModel { get; set; }
    }
}
