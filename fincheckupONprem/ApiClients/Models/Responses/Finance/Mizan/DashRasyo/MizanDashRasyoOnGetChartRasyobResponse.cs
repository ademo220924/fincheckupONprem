using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetChartRasyobResponse
    {
        public JsonElement? Response { get; set; }
    }
}
