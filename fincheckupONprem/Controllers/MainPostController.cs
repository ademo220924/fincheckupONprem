using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Common;
using fincheckup.ApiClients.Models.Requests.Bulten;
using fincheckup.ApiClients.Models.Requests.Company;
using fincheckup.ApiClients.Models.Requests.Main;
using fincheckup.ApiClients.Models.Requests.Users;
using fincheckup.ApiClients.Services;

namespace fincheckup.Controllers;


[Route("JsonService/MainPost/[action]")]
public class MainPostController(
    INotificationApiClient notificationApiClient,
    IBultenApiClient bultenApiClient,
    IUserApiClient userApiClient,
    IMainPostApiClient mainPostApiClient,
    ICompanyApiClient companyApiClient) : Controller
{
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> SendEmailAska([FromBody] SendMailRequest request, CancellationToken cancellationToken)
    {
        var data = await notificationApiClient.SendMailAsync(request,cancellationToken);
        try
        {
            return data.IsSuccess 
                ? new JsonResult(data.Data) 
                : new JsonResult(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> SendEmailAskainfo([FromBody] SendMailRequest request, CancellationToken cancellationToken)
    {
        var data = await notificationApiClient.SendMailInfoAsync(request,cancellationToken);
        try
        {
            return data.IsSuccess 
                ? new JsonResult(data.Data) 
                : new JsonResult(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);
        }
    }
    public async Task<JsonResult> FormSubmita([FromBody] BultenCreateRequest model, [FromHeader(Name = "user-id")] string userId,CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid) 
            return new JsonResult("nok");
        
        var data = await bultenApiClient.CreateAsync(model, userId);
        try
        {
            return data.IsSuccess 
                ? Json(data.Data) 
                : Json(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);
        }
    }

    public async Task<JsonResult> FormSubmitPass( [FromBody] UserPasswordChangeRequest request,
        CancellationToken cancellationToken)
    {
         
        if (!ModelState.IsValid) 
            return new JsonResult("nok");
                
        var data = await userApiClient.ChangePasswordAsync(request, cancellationToken);
        try
        {
            return data.IsSuccess 
                ? Json(data.Data) 
                : Json(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);
        }
    }
    public  async Task<JsonResult> FormSubmitError([FromBody] TblZoneErrorCreateOrUpdateRequest request,CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid) 
            return new JsonResult("nok");
                
        var data = await mainPostApiClient.TblErrorZoneCreateOrUpdateAsync(request, cancellationToken);
        try
        {
            return data.IsSuccess 
                ? Json(data.Data) 
                : Json(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);
        }
    }
    
    public async Task<JsonResult> FormSubmitCheck([FromBody] TblZoneErrorCreateOrUpdateRequest request,CancellationToken cancellationToken)
    {

        if (!ModelState.IsValid) 
            return new JsonResult("nok");

        var data = await mainPostApiClient.TblWzoneCreateAsync(request, cancellationToken);
        try
        {
            return data.IsSuccess 
                ? Json(data.Data) 
                : Json(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);
        }
    }
    
    public async Task<JsonResult> FormSubmitUser([FromBody] UserCompanyUpdateRequest request,CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid) 
            return new JsonResult("nok");

        var data = await userApiClient.UserCompanyUpdateAsync(request, cancellationToken);
        try
        {
            return data.IsSuccess 
                ? Json(data.Data) 
                : Json(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);
        }
    }
    public async Task<JsonResult> FormSubmitCompany(Company model, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
            return new JsonResult("nok");

        try
        {
            if (model.Id > 0)
            {
                var request = new CompanyUpdateRequest
                {
                    Id = model.Id,
                    Address = model.Adress,
                    CityId = model.CityId ?? 0,
                    CompanyName = model.CompanyName,
                    ContactGsm = model.ContactGsm,
                    ContactMail = model.ContactMail,
                    TaxId = model.TaxId,
                    TaxOffice = model.TaxOffice,
                    Notes = model.Notes,
                    ContactName = model.ContactName,
                    NaceCode = model.NaceCode,
                    MainCompanyId = (int)model.MainCompanyId,
                    XmlSourceId = model.XmlSourceId ?? 0,
                    State = model.State
                };

                var data = await companyApiClient.UpdateAsync(request, cancellationToken);

                return data.IsSuccess
                    ? Json(data.Data)
                    : Json(data.ProblemDetails);
            }
            else
            {
                var request = new CompanyCreateRequest
                {
                    Address = model.Adress,
                    CityId = model.CityId ?? 0,
                    CompanyName = model.CompanyName,
                    ContactGsm = model.ContactGsm,
                    ContactMail = model.ContactMail,
                    TaxId = model.TaxId,
                    TaxOffice = model.TaxOffice,
                    Notes = model.Notes,
                    ContactName = model.ContactName,
                    NaceCode = model.NaceCode,
                    MainCompanyId = (int)model.MainCompanyId,
                    XmlSourceId = model.XmlSourceId ?? 0,
                    State = model.State
                };

                var data = await companyApiClient.CreateAsync(request, cancellationToken);

                return data.IsSuccess
                    ? Json(data.Data)
                    : Json(data.ProblemDetails);
            }
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);
        }
    }
    public async Task<JsonResult> DeleteUser([FromBody] int postid, CancellationToken cancellationToken)
    {
        var userId =
            User.FindFirst("user-id")?.Value ??
            User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ??
            string.Empty;

        var response = await userApiClient.DeleteAsync(userId, postid, cancellationToken);

        if (response != null && response.IsSuccessStatusCode && response.Content != null)
        {
            return Json(response.Content.IsDeleted);
        }

        return Json("nok");
    }



    public class Model
    {
        public IFormFile File { get; set; }
        public string Param { get; set; }
        public string Parama { get; set; }
    }
    public JsonResult UploadImage(Model postimg)
    {

        string SavePath = "true";
        if (postimg != null)
        {

            //Set Key Name
            string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(postimg.File.FileName);

            //Get url To Save
            SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", ImageName);

            using (var stream = new FileStream(SavePath, FileMode.Create))
            {
                postimg.File.CopyTo(stream);
            }
        }


        return Json(SavePath);
    }
    public System.Drawing.Image DownloadImageFromUrl(string imageUrl)
    {
        System.Drawing.Image image = null;

        try
        {
            System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
            webRequest.AllowWriteStreamBuffering = true;
            webRequest.Timeout = 30000;

            System.Net.WebResponse webResponse = webRequest.GetResponse();

            System.IO.Stream stream = webResponse.GetResponseStream();

            image = System.Drawing.Image.FromStream(stream);

            webResponse.Close();
        }
        catch
        {
            return null;
        }

        return image;
    }

    [RequestSizeLimit(500000000)]
    public JsonResult UploadVideoMain(Model postimg)
    {

        //var pst = Posts.GetRow_Posts(postid);
        //if (pst.IsDeleted)
        //{
        //    pst.IsDeleted = false;
        //    pst.Update_Posts();

        //}
        //else
        //{
        //    Posts.DeletePosts(postid);
        //}
        string SavePath = "true";

        if (postimg != null)
        {

            //Set Key Name
            string ImageName = Guid.NewGuid().ToString() + ".jpg"; //Path.GetExtension(postimg.File.FileName);

            //Get url To Save
            SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", ImageName);


            using (var stream = new FileStream(SavePath, FileMode.Create))
            {
                postimg.File.CopyTo(stream);
            }
        }



        return Json(SavePath);
    }
}