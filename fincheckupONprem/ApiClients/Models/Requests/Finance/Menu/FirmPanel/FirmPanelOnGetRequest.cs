namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.FirmPanel
{
    public class FirmPanelOnGetRequest
    {
        public int year {  get; set; }
    }

    public class FirmPanelOnGetQuery
    {
        public FirmPanelOnGetRequest Request { get; set; }
    }
}
