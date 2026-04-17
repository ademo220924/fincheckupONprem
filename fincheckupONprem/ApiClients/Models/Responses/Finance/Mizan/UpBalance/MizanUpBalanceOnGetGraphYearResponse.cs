using System.Text.Json;
﻿using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetGraphYearResponse
    {
        public JsonElement? Response { get; set; }
    }
}
