using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadSmm
{
    public class MizanUploadSmmRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public long UserID;
        public long CompID;
        public int CompCount;
        public int YearCount;
        public string CompName;
        public long curcomID;
        public int curcomCount;
        public int Nacenum;

        public Entities.Company CurrentCom;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company>  mreqListCompany;


        public string currentcompname { get; set; }
    }
}
