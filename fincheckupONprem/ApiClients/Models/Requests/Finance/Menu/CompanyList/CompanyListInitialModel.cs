using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyList
{
    public class CompanyListInitialModel
    {
        public long UserID; 
        public int UserTypeID;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqList;
    }
}
