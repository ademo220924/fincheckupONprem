using fincheckup.ApiClients.Models.Requests.Finance.Menu.UserEdit;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Menu.UserEdit
{
    public class UserEditOnGetSalerMainResponse
    {
        public JsonElement? Response { get; set; }
        public UserEditInitialModel InitialModel { get; set; }
    }
}
