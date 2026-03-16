using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Models.Requests.Mizan;
using fincheckup.ApiClients.Services;

namespace fincheckup.Controllers;

[Route("JsonService/Mizan/[action]")]
public class MizanController(IWebHostEnvironment environment, IMizanApiClient mizanApiClient) : Controller
{
    public async Task<JsonResult> moodUploadMznCkeckPDFUpdate(XMlook pageIndex)
    {
        var response = await mizanApiClient.MoodUploadMznCkeckPDFUpdateAsync(new MoodUploadMznCkeckPDFUpdateRequest() { XMlook = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }

   

    public async Task<JsonResult> moodUploadMznCkeckPDF(XMlook pageIndex)
    {
        var response = await mizanApiClient.MoodUploadMznCkeckFileCreateAsync(new MoodUploadMznCkeckFileCreateRequest()
            {
                Id = pageIndex.id,
                Caption = pageIndex.Caption,
                File = pageIndex.file,
                Ide = Convert.ToInt64(pageIndex.ide),
                Idexml = Convert.ToInt64(pageIndex.idexml)
            },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
        
       
    }

    
    public async Task<JsonResult> moodUploadMznCkeck(XMlook pageIndex)
    {
        var response = await mizanApiClient.MoodUploadMznCkeckAsync(new MoodUploadMznCkeckRequest
            {
                Id = pageIndex.id,
                Caption = pageIndex.Caption,
                File = pageIndex.file,
                Ide = Convert.ToInt64(pageIndex.ide),
                Idexml = Convert.ToInt64(pageIndex.idexml)
            },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    
    public async Task<JsonResult> moodUploadMzn(XMlook pageIndex)
    {
        var response = await mizanApiClient.MoodUploadMznAsync(new MoodUploadMznRequest
            {
                Id = pageIndex.id,
                Caption = pageIndex.Caption,
                File = pageIndex.file,
                Ide = Convert.ToInt64(pageIndex.ide),
                Idexml = Convert.ToInt64(pageIndex.idexml)
            },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }

 

    [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
    [RequestSizeLimit(209715200)]
    public async Task<JsonResult> moodUploadUpdateMzn(XMlook pageIndex)
    {

        var response = await mizanApiClient.MoodUploadUpdateMznAsync(new MoodUploadUpdateMznRequest
            {
                Id = pageIndex.id,
                Caption = pageIndex.Caption,
                File = pageIndex.file,
                Ide = Convert.ToInt64(pageIndex.ide),
                Idexml = Convert.ToInt64(pageIndex.idexml)
            },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
        
    }
    
    public async Task<JsonResult> moodUpdatesmm(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
            return Json("nok");
        
        var response = await mizanApiClient.MoodUpdateSmmAsync(
            new MoodUpdateSmmRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    
    public async Task<JsonResult> moodUpdatesaktarma(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
            return Json("nok");

        var response = await mizanApiClient.MoodUpdatesAktarmaAsync(
            new MoodUpdatesAktarmaRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    public async Task<JsonResult> moodUpdatesaktarmamzn(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
            return Json("nok");

        var response = await mizanApiClient.MoodUpdatesAktarmaMznAsync(
            new MoodUpdatesAktarmaMznRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }


    public async Task<JsonResult> moodUpdatesaktarmaselected(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
            return Json("nok");
        if (pageIndex.caplist == null)
            return Json("nok");
        if (string.IsNullOrWhiteSpace(pageIndex.caplist) || pageIndex.caplist.Split(',').Length < 1)
            return Json("nok");

        var response = await mizanApiClient.MoodUpdatesAktarmaSelectedAsync(
            new MoodUpdateSaktarmaSelectedRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    public async Task<JsonResult> moodUpdatesaktarmaselectedbyn(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
            return Json("nok");
        if (pageIndex.caplist == null)
            return Json("nok");
        if (string.IsNullOrWhiteSpace(pageIndex.caplist) || pageIndex.caplist.Split(',').Length < 1)
            return Json("nok");

        var response = await mizanApiClient.MoodUpdatesAktarmaSelectedByNAsync(
            new MoodUpdatesAktarmaSelectedByNRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
    public async Task<JsonResult> moodUpdatesaktarmaselectedmzn(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
            return Json("nok");
        if (pageIndex.caplist == null)
            return Json("nok");
        if (string.IsNullOrWhiteSpace(pageIndex.caplist) || pageIndex.caplist.Split(',').Length < 1)
            return Json("nok");

        var response = await mizanApiClient.MoodUpdatesaktarmaselectedmznAsync(
            new MoodUpdatesAktarmaSelectedMznRequest() { XMlookUpdate = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
     
    public async Task<JsonResult> moodUpdateBalance(ApiClients.Models.Aggregated.XMlookUpdate pageIndex)
    {
        if (!ModelState.IsValid)
            return Json("nok");

        var response = await mizanApiClient.MoodUpdateBalanceAsync(
            new MoodUpdateBalanceRequest() { PageIndex = pageIndex },
            CancellationToken.None);

        return response.IsSuccess
            ? Json(response.Data)
            : Json(response.ProblemDetails);
    }
}