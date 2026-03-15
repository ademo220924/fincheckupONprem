using fincheckup.ApiClients.Models.Requests.Finance.Menu.UserEdit;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Menu.UserEdit
{
    public class UserEditOnGetSalerCompanyResponse
    {
        public JsonResult Response { get; set; }
        public UserEditInitialModel InitialModel { get; set; }
    }
}
