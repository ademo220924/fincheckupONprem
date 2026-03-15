using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Aggregated;


namespace fincheckup.ApiClients.Models.Requests.Finance.Upload
{
    public class FinanceUploadMainRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public IEnumerable<YearResult> mmonthResult;
        public long UserID;
        public long CompID;
        public int CompCount;
        public int YearCount;
        public long curcomID;
        public int curcomCount;
        public HhvnUsers CurrentUser;
        public IEnumerable<SourceResult> mSourceResult;
        public YearlyUploadResult currentMonth;

        public IEnumerable<YearlyUploadResult> currentUploadM;
        public IEnumerable<YearlyUploadResult> currentUploadMOK;
        public IEnumerable<YearlyUploadResult> currentUploadMNoOK;
        public List<YearlyUploadResult> currentUploadMMonth;


        public IEnumerable<Entities.Company> mreqListCompany;
        public Entities.Company currenCompanie;
        public string CompName;
        public DataViewerMain mrequestDataViewer;

        public string currentcompname { get; set; }
    }
}
