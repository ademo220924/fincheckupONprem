using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashBilanco;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashBilanco
{
    public class MizanAktarmaDashBilancoOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public MizanAktarmaDashBilancoRequestInitialModel InitialModel { get; set; }
    }
}
