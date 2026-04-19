using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaJrnl
{
    public class MizanUpPageAktarmaJrnlOnGetSalerDateMainRequest
    {
        public int nyear { get; set; }
    }

    public class MizanUpPageAktarmaJrnlOnGetSalerDateMainQuery
    {
        public MizanUpPageAktarmaJrnlOnGetSalerDateMainRequest Request { get; set; }
        public MizanUpPageAktarmaJrnlRequestInitialModel InitialModel { get; set; }
        [JsonIgnore] public  string UserId { get; set; }
    }
}
