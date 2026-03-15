using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Responses.Layouts;

public class LayoutMainResponse
{
    public long UserId { get; set; }
    public HhvnUsers HhvnUsers { get; set; }
    public User User { get; set; }
    public string UserRole { get; set; }
    public string UserApp { get; set; }
}