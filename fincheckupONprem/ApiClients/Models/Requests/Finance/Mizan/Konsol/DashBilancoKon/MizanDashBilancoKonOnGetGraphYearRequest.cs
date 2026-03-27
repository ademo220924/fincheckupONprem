using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashBilancoKon
{
    public class MizanDashBilancoKonOnGetGraphYearRequest
    {
        public int nyear {  get; set; }
    }

    public class MizanDashBilancoKonOnGetGraphYearQuery
    {
        public MizanDashBilancoKonOnGetGraphYearRequest Request { get; set; }
    }
}
