using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.UserList;

public class UserListRequestInitialModel
{
    public long UserID { get; set; }
    public HhvnUsers CurrentUser { get; set; }
    public IEnumerable<HhvnUsers> mreqList { get; set; }
}
