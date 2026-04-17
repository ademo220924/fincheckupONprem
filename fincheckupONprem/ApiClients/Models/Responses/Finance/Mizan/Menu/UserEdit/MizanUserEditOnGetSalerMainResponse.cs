using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.UserEdit
{
    public class MizanUserEditOnGetSalerMainResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUserEditRequestInitialModel InitialModel { get; set; }
    }
}
