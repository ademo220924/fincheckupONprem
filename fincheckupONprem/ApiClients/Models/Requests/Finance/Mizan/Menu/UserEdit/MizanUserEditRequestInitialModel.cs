using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit
{
    public class MizanUserEditRequestInitialModel
    {
        public long UserID;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqListCompany;
        public List<UserType> mreqListUserType;
        public IEnumerable<City> mreqListCitiy;
        public IEnumerable<YearResult> myearResult;

        public HhvnUsers mrequest;

        public string mreqListCitiystr { get; set; }
    }
}
