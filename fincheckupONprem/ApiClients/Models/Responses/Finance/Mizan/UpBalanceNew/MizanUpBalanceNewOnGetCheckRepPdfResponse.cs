using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetCheckRepPdfResponse
    {
        /// <summary>Göreli dosya yolu; tam URL Web tarafında (PublicFileHostingSettings / tarayıcı) birleştirilir.</summary>
        public string? Response { get; set; }
        public MizanUpBalanceNewRequestInitialModel InitialModel { get; set; }
    }
}
