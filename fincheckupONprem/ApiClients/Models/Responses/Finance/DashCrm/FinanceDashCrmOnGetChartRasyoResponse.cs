using fincheckup.ApiClients.Models.Requests.Finance.DashCrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashCrmRequestInitialModel InitialModel { get; set; }
    }
}
