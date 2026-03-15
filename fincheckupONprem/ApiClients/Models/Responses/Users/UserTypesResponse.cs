using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Responses.Users;

public class UserTypesResponse
{
    public List<UserType> UserTypes { get; set; }
}