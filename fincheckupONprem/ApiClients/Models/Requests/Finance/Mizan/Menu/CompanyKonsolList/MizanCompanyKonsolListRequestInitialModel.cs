using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsolList
{
    public class MizanCompanyKonsolListRequestInitialModel
    {
        public int UserID;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqList;
        public Entities.Company mrequest;
    }
}
