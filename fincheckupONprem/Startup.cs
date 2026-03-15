using ChatGptNet;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.XtraReports.Security;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System;
using fincheckup.ApiClients.Constants;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Helpers;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Models.SignOperation;
using fincheckup.ApiClients.Services.Base;
using fincheckup.StartupConfigurations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fincheckup
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;
        public static IAiModelConnect FooServiceInstance { get; private set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationHelperService, AuthenticationHelperService>();
            services.AddFinanceApiCLientWithRefit(Configuration);
            services.Configure<TokenOptions>(Configuration.GetSection(nameof(TokenOptions)));
            services.AddHttpContextAccessor();
            DatabaseApp.ConnectionApp = Configuration["QNBpay:AppID"];
            services.AddSession(opts =>
            {
                opts.Cookie.IsEssential = true;
                opts.IdleTimeout = TimeSpan.FromMinutes(30);
                opts.Cookie.MaxAge = TimeSpan.FromDays(360);
                opts.Cookie.HttpOnly = true;
            });
            services.AddChatGpt(Configuration, httpClient =>
              {
                  httpClient.AddStandardResilienceHandler(options =>
                  {
                      options.AttemptTimeout.Timeout = TimeSpan.FromMinutes(1);
                      options.CircuitBreaker.SamplingDuration = TimeSpan.FromMinutes(3);
                      options.TotalRequestTimeout.Timeout = TimeSpan.FromMinutes(3);
                  });
              });
            services.AddMvc(options => options.EnableEndpointRouting = false).AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
            services.AddMemoryCache();
            services
                    .AddAuthentication(options => { 
                        options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme; 
                        options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme; 
                        options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme; })
                    .AddCookie(options => { 
                        options.LoginPath = "/index"; 
                        options.LogoutPath = "/LogOut"; 
                        options.ExpireTimeSpan = TimeSpan.FromDays(365); 
                        options.Cookie.MaxAge = TimeSpan.FromDays(365); 
                        options.SlidingExpiration = false;
            });

            
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/index";
                options.SlidingExpiration = true;
            });
            services.Configure<KestrelServerOptions>(options =>
            {
                options.Limits.MaxRequestBodySize = 209715200;
            });
 
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllers();
            services.AddDevExpressControls();
            services.AddMvc().AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.ConfigureReportingServices(configurator =>
            {
                configurator.ConfigureWebDocumentViewer(viewerConfigurator =>
                {
                    viewerConfigurator.UseCachedReportSourceBuilder();
                });
            });
            
            services.AddSingleton<TokenService>();
            services.AddTransient<AuthenticatedHttpClientHandler>();
            
            services.AddSingleton<IAiModelConnect>();
            services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
                    .AddCertificate(); 
            services.AddAntiforgery(options =>
            {
                options.Cookie.Expiration = TimeSpan.FromHours(1);
            });
            services.AddRouting(options => options.LowercaseUrls = true);
            services.Configure<FormOptions>(options => 
            { 
                options.ValueLengthLimit = int.MaxValue; 
                options.MultipartBodyLengthLimit = int.MaxValue; 
                options.MultipartHeadersLengthLimit = int.MaxValue;

            });
            services.AddDataProtection();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowCorsPolicy", builder =>
                {
                    // Allow all ports on local host.
                    //builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
                    //builder.WithHeaders("Content-Type");
                });
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddIdentityCore<HhvnUsers>();
            services.AddMvc().AddRazorPagesOptions(ApplicationConstant.GetRazorPageOptions);
            services.ConfigureApplicationCookie(options => { options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.None; });
        }

        

        public void Configure(IApplicationBuilder app, IHostingEnvironment env , IAiModelConnect fooService) 
        {
            FooServiceInstance = fooService;

            ScriptPermissionManager.GlobalInstance = new ScriptPermissionManager(ExecutionMode.Unrestricted);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts(options => { options.MaxAge(days: 365).IncludeSubdomains().Preload(); });
            }

            app.UseDevExpressControls();
            app.UseXfo(option => { option.Deny(); });
            app.UseXXssProtection(option => { option.EnabledWithBlockMode(); });
            app.UseXContentTypeOptions();
            app.UseReferrerPolicy(opts => opts.NoReferrer());
            app.UseCookiePolicy(new CookiePolicyOptions
            {
                HttpOnly = HttpOnlyPolicy.Always,
                MinimumSameSitePolicy = SameSiteMode.Strict,
                Secure = CookieSecurePolicy.Always
            });
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                SupportedCultures = ApplicationConstant.SupportedCultures,
                SupportedUICultures = ApplicationConstant.SupportedCultures,
                DefaultRequestCulture = new RequestCulture("tr-TR")

            });
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc();
            app.UseRouting();
            app.UseCors("AllowCorsPolicy");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "areaRoute", pattern: "{area:exists}/{controller}/{action}");
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
