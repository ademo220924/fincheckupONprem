using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaJrnl
{
    public class MizanUpPageAktarmaJrnlOnGetGraphCodeRequest
    {
        public int nyear {  get; set; }
        public string ncode { get; set; }
        public float nvalue { get; set; }
        public string ncodedc { get; set; }
    }

    public class MizanUpPageAktarmaJrnlOnGetGraphCodeQuery
    {
        public MizanUpPageAktarmaJrnlOnGetGraphCodeRequest Request { get; set; }
        
        public MizanUpPageAktarmaJrnlRequestInitialModel InitialModel { get; set; }
        [JsonIgnore] public  string UserId { get; set; }
    }
}
