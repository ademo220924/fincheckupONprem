using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaJrnl;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.UpPageAktarmaJrnl
{
    public class MizanUpPageAktarmaJrnlOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUpPageAktarmaJrnlRequestInitialModel InitialModel { get; set; }
    }
}
