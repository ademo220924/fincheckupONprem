using System.Security.Claims;
using System.Text.Json.Serialization;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Responses.Authentication;

public class LoginResponse
{
    [JsonPropertyName("redirectUrl")] public string RedirectUrl { get; set; } = string.Empty;
    [JsonPropertyName("responseDigit")] public int ResponseDigit { get; set; }
    [JsonPropertyName("accessToken")] public string AccessToken { get; set; } = string.Empty;
    [JsonPropertyName("hhvnUser")] public HhvnUsers HhvnUser { get; set; }
    [JsonPropertyName("user")] public User User { get; set; }
}
