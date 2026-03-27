using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtFiba
{
    public class MizanFinanceHrtFibaOnGetMarkupMarjinCRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanFinanceHrtFibaOnGetMarkupMarjinCQuery
    {
        public MizanFinanceHrtFibaOnGetMarkupMarjinCRequest Request { get; set; }
    }
}
