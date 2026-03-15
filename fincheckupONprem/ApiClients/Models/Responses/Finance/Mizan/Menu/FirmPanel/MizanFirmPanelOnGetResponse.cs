using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.FirmPanel;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.FirmPanel
{
    public class MizanFirmPanelOnGetResponse
    {
        public MizanFirmPanelRequestInitialModel InitialModel { get; set; }
        public string ResponseRedirectUrl { get; set; } = string.Empty;
    }
}
