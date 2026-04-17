using System.Text.Json;
﻿using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetSalerCompResponse
    {
        public JsonElement? Response { get; set; }
    }
}
