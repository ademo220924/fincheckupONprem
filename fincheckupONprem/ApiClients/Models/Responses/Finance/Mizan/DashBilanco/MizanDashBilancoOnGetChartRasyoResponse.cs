using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilanco;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilanco
{
    public class MizanDashBilancoOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashBilancoRequestInitialModel InitialModel { get; set; }
    }
}
