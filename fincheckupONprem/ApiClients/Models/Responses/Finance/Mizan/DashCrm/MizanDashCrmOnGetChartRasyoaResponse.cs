using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashCrm;

public class MizanDashCrmOnGetChartRasyoaResponse
{
    public JsonElement? Response { get; set; }
    public MizanDashCrmRequestInitialModel InitialModel { get; set; }
    
}
