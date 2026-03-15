using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.CashFlow;
public class CashFlowRequestModel
{

    public IEnumerable<YearResult> myearResult;
    public int UserID;
    public string CompName { get; set; }
    public long CompID;
    public int CompCount;
    public int YearCount;
    public HhvnUsers CurrentUser;
    public DashYearlyBilancoChart ncart;
    public List<DashBilancoView> nRequestList;
    public IEnumerable<Entities.Company> mreqListCompany;
    public string NetIsletme { get; set; }
    public string CariOran { get; set; }
    public decimal CariOranT { get; set; }
    public string NakitOran { get; set; }
    public long val1 { get; set; }
    public long val3 { get; set; }
}