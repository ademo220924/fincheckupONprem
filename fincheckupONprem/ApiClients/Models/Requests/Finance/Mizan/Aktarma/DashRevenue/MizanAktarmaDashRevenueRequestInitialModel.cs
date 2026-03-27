using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashRevenue
{
    public class MizanAktarmaDashRevenueRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult { get; set; }
        public long UserID { get; set; }
        public long CompID { get; set; }
        public int CompCount { get; set; }
        public int YearCount { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<DashBilancoViewMznShort> nRequestList { get; set; }

        public IEnumerable<DashBilancoViewMznShort> nRequestListChk { get; set; }
        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public string NetIsletme { get; set; }
        public string CariOran { get; set; }
        public decimal CariOranT { get; set; }
        public string NakitOran { get; set; }
        public long val1 { get; set; }
        public string CompName;
        public long val3 { get; set; }
    }
}