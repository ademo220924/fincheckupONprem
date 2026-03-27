using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaMzn
{
    public class FinanceUpPageAktarmaMznRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public long UserID;
        public long CompID;
        public int CompCount;
        public int YearCount;
        public long curcomID;
        public int curcomCount;
        public int Nacenum;
        public Entities.Company CurrentCom;
        public string CompName;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqListCompany;
        public string currentcompname { get; set; }
    }
}
