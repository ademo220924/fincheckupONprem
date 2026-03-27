using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashBilancoKon
{
    public class MizanDashBilancoKonOnGetRequest
    {
        public int Year {  get; set; }
    }

    public class MizanDashBilancoKonOnGetQuery
    {
        public MizanDashBilancoKonOnGetRequest Request { get; set; }
    }
}
