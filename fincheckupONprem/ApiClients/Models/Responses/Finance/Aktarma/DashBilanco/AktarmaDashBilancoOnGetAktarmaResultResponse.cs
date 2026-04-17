using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashBilanco;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashBilanco;
public class AktarmaDashBilancoOnGetAktarmaResultResponse
{
    public JsonElement? Response { get; set; }
    public AktarmaDashBilancoInitialModel InitialModel { get; set; }
}
