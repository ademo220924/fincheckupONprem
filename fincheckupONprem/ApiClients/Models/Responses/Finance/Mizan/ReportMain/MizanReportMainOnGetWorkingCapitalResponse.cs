using System.Text.Json;
﻿using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMain
{
    public class MizanReportMainOnGetWorkingCapitalResponse
    {
        public JsonElement? Response { get; set; }
    }
}
