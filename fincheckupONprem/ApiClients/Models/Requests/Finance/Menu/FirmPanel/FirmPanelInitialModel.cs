using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.FirmPanel
{
    public class FirmPanelInitialModel
    {
        public long UserID;
        public int UserTypeID;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqList;
    }
}
