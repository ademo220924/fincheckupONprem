using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaMizan;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUpPageAktarmaRequestInitialModel InitialModel { get; set; }
    }
}
