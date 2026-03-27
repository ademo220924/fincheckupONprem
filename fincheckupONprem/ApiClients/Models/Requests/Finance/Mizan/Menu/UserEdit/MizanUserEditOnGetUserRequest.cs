using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit
{
    public class MizanUserEditOnGetUserRequest
    {
        public int id { get; set; } = 0;
        public string ide { get; set; } = "0";
    }

    public class MizanUserEditOnGetUserQuery
    {
        public MizanUserEditOnGetUserRequest Request { get; set; }
    }
}
