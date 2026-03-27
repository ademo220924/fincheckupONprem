using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtFiba
{
    public class MizanFinanceHrtFibaOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtFibaOnGetMarkupMarjinQuery
    {
        public MizanFinanceHrtFibaOnGetMarkupMarjinRequest Request { get; set; }
    }
}
