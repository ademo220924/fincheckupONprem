using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaJrnl
{
    public class FinanceUpPageAktarmaJrnlRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public IEnumerable<DebitCreditResult> mDcResult;
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
