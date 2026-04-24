using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit
{
    public class MizanUserEditOnGetSalerCompanyRequest
    {
        public DataSourceLoadOptions options {  get; set; }
        public string dt1 { get; set; }
        public int EditedUserId { get; set; }
    }

    public class MizanUserEditOnGetSalerCompanyQuery
    {
        public MizanUserEditOnGetSalerCompanyRequest Request { get; set; }
    }
}
