using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserList
{
    public class MizanUserListRequestInitialModel
    {
        public long UserID;
        public HhvnUsers CurrentUser;
        public IEnumerable<HhvnUsers> mreqList;
    }
}
