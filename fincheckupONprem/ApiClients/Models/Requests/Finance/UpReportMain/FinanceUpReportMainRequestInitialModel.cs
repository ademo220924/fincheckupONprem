using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpReportMain
{
    public class FinanceUpReportMainRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public long UserID;
        public long CompID;
        public int CompCount;
        public string CompName;
        public int YearCount;
        public long curcomID;
        public int curcomCount;
        public HhvnUsers CurrentUser;
        public int YearCurrent; 
        public IEnumerable<Entities.Company> mreqListCompany;
        public Entities.Company curCompany;
        public int nyear;
        public long companyID;
        public string currentcompname { get; set; }
        public string FilePath { get; set; }
    }
}
