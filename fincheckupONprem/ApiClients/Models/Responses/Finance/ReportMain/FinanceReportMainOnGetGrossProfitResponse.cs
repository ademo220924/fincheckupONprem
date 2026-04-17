using System.Text.Json;
﻿using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.ReportMain
{
    public class FinanceReportMainOnGetGrossProfitResponse
    {
        public JsonElement? Response { get; set; }
    }
}
