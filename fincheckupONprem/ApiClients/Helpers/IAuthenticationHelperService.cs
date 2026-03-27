using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Responses.Users;
using fincheckup.ApiClients.Models.SignOperation;
using fincheckup.ApiClients.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace fincheckup.ApiClients.Helpers;

public interface IAuthenticationHelperService
{
    Task<AccessToken> SignIn(User user, CancellationToken cancellationToken);
    string GetBaseUrl();
    //Task<UserTypeResponse> GetUserRole(User user);
}

public class AuthenticationHelperService : IAuthenticationHelperService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IUserApiClient _userApiClient;
    private readonly TokenOptions _tokenOptions;
    private readonly DateTime _accessTokenExpiration;

    public AuthenticationHelperService(
        IOptions<TokenOptions> tokenOptions,
        IUserApiClient userApiClient,
        IHttpContextAccessor httpContextAccessor
    )
    {
        _tokenOptions = tokenOptions.Value;
        _accessTokenExpiration = DateTime.Now.AddMinutes(value: _tokenOptions.AccessTokenExpiration);
        _userApiClient = userApiClient;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<AccessToken> SignIn(User user,CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(user);

        var roleInfo = await GetUserRole(user); 
        var role = roleInfo == null || roleInfo.UserType == null 
            ? "Customer" 
            : roleInfo.UserType.Type;
 
        var identity = GetClaimsIdentity(user,role);

        var principal = new ClaimsPrincipal(identity);
        _ = _httpContextAccessor.HttpContext?.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
            principal,
            new AuthenticationProperties
            {
                IssuedUtc = DateTime.UtcNow,
                IsPersistent = false,
                ExpiresUtc = DateTime.UtcNow.AddMinutes(35)
            });

        
        var tokenModel = CreateAccessToken(user,role, identity.Claims);
        _httpContextAccessor.HttpContext?.Response?.Headers.Append("Authorization", "Bearer " + tokenModel.Token);

        return tokenModel;
    }

    public string GetBaseUrl()
    {
        return _httpContextAccessor.HttpContext?.Request.Scheme + "://" +_httpContextAccessor.HttpContext?.Request.Host.Value;
    }

    public async Task<UserTypeResponse> GetUserRole(User user)
    {
        var role = await _userApiClient
                                                   .GetTypeByIdAsync((int)user.UserTypeId);
        return role.Data;
    }

    private static ClaimsIdentity GetClaimsIdentity(User user, string role)
    {
      var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
        identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
        identity.AddClaim(new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"));
        identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
        identity.AddClaim(new Claim(ClaimTypes.Role, role));
        identity.AddClaim(new Claim("role-id", role));
        identity.AddClaim(new Claim("user-id", user.Id.ToString()));

        return identity;
    }

    private AccessToken CreateAccessToken(User user, string role, IEnumerable<Claim> claims)
    {
        var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_tokenOptions.SecurityKey));
        var signingCredential = new SigningCredentials(securityKey, SecurityAlgorithms.Aes128CbcHmacSha256);
        var jwt = CreateJwtSecurityToken(user, role,signingCredential, claims);
        var token = new JwtSecurityTokenHandler().WriteToken(jwt);
        return new AccessToken
        {
            Token = token,
            Expiration = _accessTokenExpiration
        };
    }

    private JwtSecurityToken CreateJwtSecurityToken(User user, string role, SigningCredentials signingCredentials, IEnumerable<Claim> claims)
    {
        var jwt = new JwtSecurityToken(
            issuer: _tokenOptions.Issuer,
            audience: _tokenOptions.Audience,
            expires: _accessTokenExpiration,
            notBefore: DateTime.Now,
            claims: SetClaims(user,role, claims),
            signingCredentials: signingCredentials
            );

        return jwt;
    }

    private static List<Claim> SetClaims(User user, string role, IEnumerable<Claim> claimList)
    {
       
        var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Email, user.Email),
                new(ClaimTypes.NameIdentifier, user.UserGuid.ToString()),
                new(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Role, role),
                new("role-id", role),
                new("user-id", user.Id.ToString())
            };
        claimList.Select(x => "RoleId").Distinct().ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));
        return claims;
    }

}