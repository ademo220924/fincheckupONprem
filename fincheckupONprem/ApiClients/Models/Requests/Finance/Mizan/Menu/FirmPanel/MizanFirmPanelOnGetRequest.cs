
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.FirmPanel
{
    public class MizanFirmPanelOnGetRequest
    {
        public int year { get; set; } = 2021;
    }

    public class MizanFirmPanelOnGetQuery
    {
        public MizanFirmPanelOnGetRequest Request { get; set; }
    }
}
