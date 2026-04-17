using System.Text.Json;
﻿using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.CashFlow
{
    public class MizanCashFlowOnGetGraphYearResponse
    {
        public JsonElement? Response { get; set; }
    }
}
