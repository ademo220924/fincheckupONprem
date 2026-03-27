using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.FirmPanel
{
    public class FirmPanelInitialModel
    {
        public long UserID { get; set; }
        public int UserTypeID { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<Entities.Company> mreqList { get; set; }
    }
}
