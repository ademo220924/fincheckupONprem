using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUpPageAktarmaOnGetSalerDateQuery
    {
        public MizanUpPageAktarmaOnGetSalerDateRequest Request { get; set; }
        public MizanUpPageAktarmaRequestInitialModel InitialModel { get; set; }
        [JsonIgnore] public  string UserId { get; set; }
    }
}
