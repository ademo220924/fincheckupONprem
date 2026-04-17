using System.Text.Json;
﻿using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrtView
{
    public class MizanFinanceHrtViewOnGetWorkingCapitalResponse
    {
        public JsonElement? Response { get; set; }
    }
}
