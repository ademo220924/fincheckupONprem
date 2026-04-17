using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetDashRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashRasyoRequestInitialModel InitialModel { get; set; }
    }
}
