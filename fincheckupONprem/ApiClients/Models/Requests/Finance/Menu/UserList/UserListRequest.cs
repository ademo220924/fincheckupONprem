using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.UserList
{
    public class UserListRequest
    {
        public long UserID;
        public HhvnUsers CurrentUser;
        public IEnumerable<HhvnUsers> mreqList;
    }

    public class UserListQuery
    {
        public UserListRequest Request { get; set; }
    }
}
