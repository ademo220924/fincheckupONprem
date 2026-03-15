using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Models.Requests.Home;
using fincheckup.ApiClients.Services;
using fincheckup.Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.Controllers;

[Microsoft.AspNetCore.Components.Route("JsonService/Main/[action]")]
public class HomeController : Controller
{
    private IWebHostEnvironment _hostingEnvironment;
    private readonly IHomeApiCLient _homeApiCLient;
    public HomeController(IWebHostEnvironment environment,IHomeApiCLient homeApiCLient)
    {
        _hostingEnvironment = environment;
        _homeApiCLient = homeApiCLient;
    }


    public async Task<JsonResult> moodUpdate(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        {
            return Json("nok");
        }
 
        var response = await _homeApiCLient.MoodUpdateAsync(new MoodUpdateRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    [RequestFormLimits(MultipartBodyLengthLimit = 9509715200)]
    [RequestSizeLimit(9509715200)]
    public async Task<JsonResult> moodUpload(XMlook pageIndex)
    {
        var response = await _homeApiCLient.MoodUploadAsync(new MoodUploadRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }

    public async Task<JsonResult> moodUploadNwMizan(XMlook pageIndex)
    {
        var response = await _homeApiCLient.MoodUploadNwMizanAsync(new MoodUploadNwMizanRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    
    public async Task<JsonResult> moodUploadNwUpdateMizan(XMlook pageIndex)
    {
        var response = await _homeApiCLient.MoodUploadNwUpdateMizanAsync(new MoodUploadNwUpdateMizanRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }

    [RequestFormLimits(MultipartBodyLengthLimit = 9509715200)]
    [RequestSizeLimit(9509715200)]
    public  async Task<JsonResult> moodUploadOneProcess(XMlook pageIndex)
    {
        var response = await _homeApiCLient.MoodUploadOneProcessAsync(new MoodUploadOneProcessRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);

    }
    [HttpPost]
    [RequestFormLimits(MultipartBodyLengthLimit = 9509715200)]
    [RequestSizeLimit(9509715200)]
    public async Task<JsonResult> moodUploadOne(XMlook pageIndex)
    {
        var response = await _homeApiCLient.MoodUploadOneAsync(new MoodUploadOneRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    
    [RequestFormLimits(MultipartBodyLengthLimit = 9509715200)]
    [RequestSizeLimit(9509715200)]
    public async Task<JsonResult> moodUploadOneUpdate(XMlook pageIndex)
    {
        var response = await _homeApiCLient.MoodUploadOneUpdateAsync(new MoodUploadOneUpdateRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }


    [RequestFormLimits(MultipartBodyLengthLimit = 9509715200)]
    [RequestSizeLimit(9509715200)]
    public async Task<JsonResult> moodUploadOneGoOn(XMlook pageIndex)
    {
        var response = await _homeApiCLient.MoodUploadOneGoOnAsync(new MoodUploadOneGoOnRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    private string ConvertDatum(string datta)
    {
        string[] listo = datta.Substring(0, 10).Replace("-", ".").Replace("/", ".").Split('.');
        return listo[0] + "." + listo[2] + '.' + listo[1];
    }
    [RequestFormLimits(MultipartBodyLengthLimit = 9509715200)]
    [RequestSizeLimit(9509715200)]
    public async Task<JsonResult> moodUploadUpdate(XMlook pageIndex)
    {
        var response = await _homeApiCLient.MoodUploadUpdateAsync(new MoodUploadUpdateRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    public async Task<JsonResult> moodUpdateTax(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        { 
            return Json("nok");
        }

        var response = await _homeApiCLient.MoodUpdateTaxAsync(new MoodUpdateTaxRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    public async Task<JsonResult> moodUpdateReport(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        {

            return Json("nok");
        }
        var response = await _homeApiCLient.MoodUpdateReportAsync(new MoodUpdateReportRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    public async Task<JsonResult> moodUpdateBalance(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        {

            return Json("nok");
        }
        var response = await _homeApiCLient.MoodUpdateBalanceAsync(new MoodUpdateBalanceRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    public async Task<JsonResult> moodUpdateKonsol(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        {

            return Json("nok");
        }
        var response = await _homeApiCLient.MoodUpdateKonsolAsync(new MoodUpdateKonsolRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }

    public async Task<JsonResult> moodUpdateKonsolMizan(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        {

            return Json("nok");
        }
        var response = await _homeApiCLient.MoodUpdateKonsolMizanAsync(new MoodUpdateKonsolMizanRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    public async Task<JsonResult> moodUpdateAccountCheck(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        {

            return Json("nok");
        }

        var response = await _homeApiCLient.MoodUpdateAccountCheckAsync(new MoodUpdateAccountCheckRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);

    }
    public async Task<JsonResult> moodUpdateReportmain(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        {

            return Json("nok");
        }

        var response = await _homeApiCLient.MoodUpdateReportmainAsync(new MoodUpdateReportmainRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }


    public async Task<JsonResult> moodUpdateReportmainQnb(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
        {

            return Json("nok");
        }

        var response = await _homeApiCLient.MoodUpdateReportmainQnbAsync(new MoodUpdateReportmainQnbRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);


    }
    public async Task<JsonResult> GetHtml([FromBody] int pageIndex)
    {
        var response = await _homeApiCLient.GetHtmlAsync(new GetHtmlRequest { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }

    private double ConvertDec(string datta)
    {
        double numvalue;
        bool isNumber = double.TryParse(datta, out numvalue);


        if (isNumber)
        {
            return numvalue;
        }
        else
        {
            return 0;
        }
    }
}