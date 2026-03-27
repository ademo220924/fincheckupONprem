using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserList
{
    public class MizanUserListRequestInitialModel
    {
        public long UserID { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<HhvnUsers> mreqList { get; set; }
    }
}
