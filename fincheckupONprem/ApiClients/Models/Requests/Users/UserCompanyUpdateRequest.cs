using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Users;

public class UserCompanyUpdateRequest
{
    public int Id { get; set; }
    public string OperationUserId { get; set; }
    public List<long> CompanyList { get; set; }
    [JsonIgnore] public string UserId { get; set; }
}

public class UserCompanyUpdateQuery
{
    public UserCompanyUpdateRequest Request { get; set; }
}
