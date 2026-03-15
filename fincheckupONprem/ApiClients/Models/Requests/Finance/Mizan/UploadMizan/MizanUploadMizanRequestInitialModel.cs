using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Models.ViewModel.Mizan;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public int UserID;
        public long CompID;
        public int CompCount;
        public int YearCount;
        public long curcomID;
        public int curcomCount;

        public HhvnUsers CurrentUser;
        public YearlyUploadResult currentMonth;
        public IEnumerable<TBLXMLSCheckpdfMizan> ncomparelist;
        public IEnumerable<YearlyUploadResult> currentUploadM;
        public IEnumerable<YearlyUploadResult> currentUploadMOK;
        public IEnumerable<YearlyUploadResult> currentUploadMNoOK;
        public List<YearlyUploadResult> currentUploadMMonth;
        public List<byte> monthlist;
        public DataViewerMain mrequestDataViewer;
        public string mnthcomparelist;
        public IEnumerable<Entities.Company> mreqListCompany;
        public Entities.Company currenCompanie;
        public string CompName;


        public string currentcompname { get; set; }
    }
}
