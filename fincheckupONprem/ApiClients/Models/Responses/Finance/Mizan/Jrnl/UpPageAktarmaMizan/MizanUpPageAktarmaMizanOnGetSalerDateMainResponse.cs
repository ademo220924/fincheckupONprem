using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaMizan;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.UpPageAktarmaMizan
{
    public class MizanUpPageAktarmaMizanOnGetSalerDateMainResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUpPageAktarmaMizanRequestInitialModel InitialModel { get; set; }
    }
}
