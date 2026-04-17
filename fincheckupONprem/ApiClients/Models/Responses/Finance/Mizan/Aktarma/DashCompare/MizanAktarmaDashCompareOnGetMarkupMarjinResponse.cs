using Microsoft.AspNetCore.Mvc;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashCompare;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashCompare
{
    public class MizanAktarmaDashCompareOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public MizanAktarmaDashCompareRequestInitialModel InitialModel { get; set; }
    }
}
