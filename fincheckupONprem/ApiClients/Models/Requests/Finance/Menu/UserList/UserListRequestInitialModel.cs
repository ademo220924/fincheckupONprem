using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.UserList;

public class UserListRequestInitialModel
{
    public long UserID;
    public HhvnUsers CurrentUser;
    public IEnumerable<HhvnUsers> mreqList;
}
