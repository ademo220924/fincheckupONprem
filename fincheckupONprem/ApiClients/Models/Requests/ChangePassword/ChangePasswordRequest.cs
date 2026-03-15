using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.ChangePassword;
public class ChangePasswordRequest
{

    public long? UserID { get; set; }
    public HhvnUsers? CurrentUser { get; set; }
    public IEnumerable<Entities.Company>? mreqListCompany { get; set; }
    public List<UserType>? mreqListUserType { get; set; }
    public IEnumerable<City>? mreqListCity { get; set; }
    public IEnumerable<YearResult>? myearResult { get; set; }
    public HhvnUsers? mrequest { get; set; }
    public string? mreqListCitystr { get; set; }
}