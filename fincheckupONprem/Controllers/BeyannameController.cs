using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace fincheckup.Controllers;

[Route("JsonService/Beyanname/[action]")]
public class BeyannameController(IBeyannameApiClient beyannameApiClient) : Controller
{
    
    [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
    [RequestSizeLimit(209715200)]
    public async Task<JsonResult> moodUpload(XMlook pageIndex)
    {
        await using var fileStreams = pageIndex.file.FirstOrDefault()!.OpenReadStream();
        var response= await beyannameApiClient.MoodUploadCreateAsync(fileStreams, pageIndex.id, pageIndex.ide, pageIndex.idexml, pageIndex.Caption, "");

       return Json(response.Data);
    }


    [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
    [RequestSizeLimit(209715200)]
    public async Task<JsonResult> moodUploadUpdate(XMlook pageIndex)
    {
        await using var fileStreams = pageIndex.file.FirstOrDefault()!.OpenReadStream();
        var response = await beyannameApiClient
                                                            .MoodUploadUpdateAsync(fileStreams, 
                                                                                    pageIndex.id, 
                                                                                    pageIndex.ide,
                                                                                    pageIndex.idexml, 
                                                                                    pageIndex.Caption, 
                                                                                    "");
        return Json(response.Data);
    }

    public async Task<JsonResult> moodUploadBeyannameChkz(XMlook pageIndex)
    {
        await using var fileStreams = pageIndex.file.FirstOrDefault()!.OpenReadStream();
        var response = await beyannameApiClient
            .MoodUploadBeyannameChkzAsync(fileStreams,
                pageIndex.id, 
                pageIndex.ide,
                pageIndex.idexml, 
                pageIndex.Caption, 
                ""); 
        
        return Json(response.Data);
    }
    
   
    public async Task<JsonResult> moodUploadBeyanname(XMlook pageIndex)
    {
        await using var fileStreams = pageIndex.file.FirstOrDefault()!.OpenReadStream();
        var response = await beyannameApiClient
            .MoodUploadBeyannameCreateAsync(fileStreams,
                pageIndex.id, 
                pageIndex.ide,
                pageIndex.idexml, 
                pageIndex.Caption, 
                ""); 
        
        return Json(response.Data);
    }

    public async Task<JsonResult> moodUploadBeyannameUpdate(XMlook pageIndex)
    {
        await using var fileStreams = pageIndex.file.FirstOrDefault()!.OpenReadStream();
        var response = await beyannameApiClient
            .MoodUploadBeyannameUpdateAsync(fileStreams,
                pageIndex.id, 
                pageIndex.ide,
                pageIndex.idexml, 
                pageIndex.Caption, 
                "");

        return Json(response.Data);
    }
}
