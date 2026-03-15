using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsolList
{
    public class CompanyKonsolListInitialModel
    {
        public int UserID;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqList;
        public Entities.Company mrequest;
    }
}
