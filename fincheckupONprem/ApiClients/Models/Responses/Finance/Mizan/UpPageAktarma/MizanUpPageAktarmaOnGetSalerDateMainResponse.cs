using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetSalerDateMainResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUpPageAktarmaRequestInitialModel InitialModel { get; set; }
    }
}
