using System.Text.Json;
﻿using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetSalerYearResponse
    {
        public JsonElement? Response { get; set; }
    }
}
