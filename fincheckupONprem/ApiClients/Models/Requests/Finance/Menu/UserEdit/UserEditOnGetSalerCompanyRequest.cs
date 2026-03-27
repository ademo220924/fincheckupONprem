using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.UserEdit
{
    public class UserEditOnGetSalerCompanyRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public UserEditInitialModel UserEditInitialModel { get; set; }
    }

    public class UserEditOnGetSalerCompanyQuery
    {
        public UserEditOnGetSalerCompanyRequest Request { get; set; }
    }
}
