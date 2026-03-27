using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit
{
    public class MizanUserEditOnGetSalerCityRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUserEditOnGetSalerCityQuery
    {
        public MizanUserEditOnGetSalerCityRequest Request { get; set; }
    }
}
