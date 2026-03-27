using fincheckup.ApiClients.Entities;

using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Requests.dashbilsample;
public class dashbilsampleRequest
{

    public IEnumerable<YearResult> myearResult;
    public long UserID;
    public long CompID;
    public int CompCount;
    public int YearCount;
    public HhvnUsers CurrentUser;
    public IEnumerable<DashBilancoViewMznShort> nRequestList;

    public IEnumerable<DashBilancoViewMznShort> nRequestListChk;
    public IEnumerable<Entities.Company> mreqListCompany;
    public string NetIsletme { get; set; }
    public string CariOran { get; set; }
    public decimal CariOranT { get; set; }
    public string NakitOran { get; set; }
    public string CompName;
    public long val1 { get; set; }
    public long val3 { get; set; }
}