using fincheckup.ApiClients.Models.Requests.Authentication;
using fincheckup.ApiClients.Services;
using fincheckup.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Helpers;
using fincheckup.ApiClients.Services.Base;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace fincheckup.Controllers;

[Route("JsonService/Havvana/[action]")]
public class HvvnController(
    IAuthenticationApiClient authenticationApiClient,
    TokenService tokenService,
    IAuthenticationHelperService authenticationHelperService) : Controller
{

    [ValidateAntiForgeryToken]
    public async Task<IActionResult> LoginProcess(AddressFormVm model, CancellationToken cancellationToken)
    {
        if (DateTime.Now.Year > 2028) 
            return Json("nok");
        
        if (ModelState.IsValid)
        {
            var request = new LoginRequest { MailAddress = model.name, Password = model.pass };
            try
            {
                var response = await authenticationApiClient.LoginAsync(request, cancellationToken);

                if (response.IsSuccess)
                {
                    var bearerToken = response.Data?.AccessToken;
                    tokenService.SetToken(bearerToken);
                    var loginResponse = response.Data;


                    //await authenticationHelperService.SignIn(loginResponse.User, cancellationToken);
                    
                    
                    SignIn(loginResponse?.HhvnUser,bearerToken);
                    
                   RedirectToPage(loginResponse.RedirectUrl); 
                    return Json(loginResponse.ResponseDigit);
                }

                TempData["Fail"] = response.ProblemDetails.Detail;
                return Json("nok");
            }
            catch (Exception ex)
            {
                TempData["Fail"] = $"Beklenmeyen Hata: {ex.Message}";
                return Json("nok");
            }
        }

        return BadRequest(ModelState);
    }
    
    private void SignIn(HhvnUsers user, string bearerToken)
    {

        var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
        identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
        identity.AddClaim(new Claim(ClaimTypes.Name, user.Email));
        identity.AddClaim(new Claim(ClaimTypes.Role, user.UserType));
        string role = user.UserType;
        identity.AddClaim(new Claim("RoleId", role));

        var principal = new ClaimsPrincipal(identity);

        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
            principal,
            new AuthenticationProperties
            {
                IssuedUtc = DateTime.UtcNow,
                IsPersistent = false,
                ExpiresUtc = DateTime.UtcNow.AddMinutes(35)
            });

        HttpContext.Request?.Headers.Append("Authorization", "Bearer " + bearerToken);
        HttpContext.Request?.Headers.Append("user-id", user.Id.ToString());
        HttpContext.Items.Add("user-id", user.Id.ToString());
        
        HttpContext.Request?.Headers.Append("role-id", role);
        HttpContext.Items.Add("role-id", role);
        
    }
}