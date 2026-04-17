using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaMizan;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetSalerDateMainResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUpPageAktarmaMizanRequestInitialModel InitialModel { get; set; }
    }
}
