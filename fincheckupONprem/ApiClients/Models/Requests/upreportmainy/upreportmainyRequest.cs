using fincheckup.ApiClients.Entities;

using System.Collections.Generic;



namespace fincheckup.ApiClients.Models.Requests.upreportmainy;
public class upreportmainyRequest
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



    public IEnumerable<Entities.Company> mreqListCompany;
    public Entities.Company curCompany;


    public string currentcompname { get; set; }
}