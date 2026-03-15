using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace fincheckup.ApiClients.Constants;

public static class ApplicationConstant
{
    public static readonly List<CultureInfo> SupportedCultures = [new("tr-TR"), new("en-US")];

    public static void GetRazorPageOptions(RazorPagesOptions options)
    {
        options.Conventions.AuthorizeFolder("/");
        options.Conventions.AuthorizeFolder("/Admin");
        options.Conventions.AuthorizeFolder("/Transaction");
        options.Conventions.AllowAnonymousToPage("/Index");
        options.Conventions.AllowAnonymousToPage("/sso");
        options.Conventions.AllowAnonymousToPage("/ssoconsult");
        options.Conventions.AllowAnonymousToPage("/LoginArea");
        options.Conventions.AllowAnonymousToPage("/Login");
        options.Conventions.AllowAnonymousToPage("/EnableAuthenticator");
        options.Conventions.AllowAnonymousToPage("/LoginWith2fa");
        options.Conventions.AllowAnonymousToPage("/gizlilik");
        options.Conventions.AllowAnonymousToPage("/about");
        options.Conventions.AllowAnonymousToPage("/kullanici");
        options.Conventions.AllowAnonymousToPage("/contact");
        options.Conventions.AllowAnonymousToPage("/kvkk");
        options.Conventions.AllowAnonymousToPage("/cozumlerimiz");
        options.Conventions.AllowAnonymousToPage("/payment");
        options.Conventions.AllowAnonymousToPage("/pageget");
        options.Conventions.AllowAnonymousToPage("/dijitalkopru");
        options.Conventions.AllowAnonymousToPage("/urunlerimiz");
        //options.Conventions.AllowAnonymousToPage("/service");
        //options.Conventions.AllowAnonymousToPage("/blogdetail");
        //options.Conventions.AllowAnonymousToPage("/blog");
        //options.Conventions.AllowAnonymousToPage("/projectdetail");
        //options.Conventions.AllowAnonymousToPage("/project");
        //options.Conventions.AllowAnonymousToPage("/contact");
    }
}