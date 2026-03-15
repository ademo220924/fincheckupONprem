using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMainTestOld
{
    public class FinanceReportMainTestOldRequestInitialModel
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
        public List<CompanyReport> reportList;

        public IEnumerable<Entities.Company> mreqListCompany;
        public Entities.Company curCompany;
        public Nacecode codde;
        public List<int> curCompanyYearList;
        public IEnumerable<int> curCompanyNonYearList;


        public string currentcompname { get; set; }
        public string FilePath { get; set; }
        public string FileDocz { get; set; }
    }
}
