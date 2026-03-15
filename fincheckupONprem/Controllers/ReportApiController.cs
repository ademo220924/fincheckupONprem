using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Entities.BgServer;
using fincheckup.ApiClients.Services;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Reminder.Account;
using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.Controllers;

[Route("ReportApi/[action]")]
public class ReportApiController(
    IReminderAccountApiClient reminderAccountApiClient,
    IReportApiClient reportApiClient) : Controller
{
    ReportFilterView nReportFilterView = new ReportFilterView();
    IEnumerable<DataViewer> nlist;
    DataViewerMain mrequestDataViewer;


    public async Task<JsonResult> GetList(DataSourceLoadOptions loadOptions, string userData)
    {
        try
        {
            var result = await reportApiClient.GetListAsync(new ApiClients.Models.Requests.ReportApis.ReportGetListRequest
            {
                LoadOptions = loadOptions,
                UserData = userData
            }, default);


            if (result.IsSuccess)
            {
                return Json(result.Data.EntryData);
            }
            else
            {
                return Json(result.ProblemDetails.Detail);
            }

        }
        catch (Exception ex)
        {
            return Json(ex.Message);
        }
    }


    [HttpPut]
    public async Task<IActionResult> PutOrderItem(int key, string values)
    {

        try
        {
            var result = await reportApiClient.PutOrderItemAsync(new ApiClients.Models.Requests.ReportApis.ReportPutOrderItemRequest
            {
                Key = key,
                Values = values,
                UserId = string.Empty

            }, default);


            if (result.IsSuccess)
                return Ok();
            return Json(result.ProblemDetails.Detail);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public async Task<JsonResult> GetListOrderItem(DataSourceLoadOptions loadOptions, string userData)
    {
        try
        {
            var result = await reportApiClient.GetListOrderItemAsync(
                new ApiClients.Models.Requests.ReportApis.GetListOrderItemRequest
                {
                    UserData = userData,
                }, default);

            if (result.IsSuccess)
                return Json(result.Data);
            return Json(result.ProblemDetails.Detail);

        }
        catch (Exception ex)
        {
            return Json(ex.Message);
        }
    }

    public async Task<JsonResult> GetListDailyInOrderItem(DataSourceLoadOptions loadOptions, string userData)
    {

        try
        {
            var result = await reportApiClient.GetListDailyInOrderItemAsync(
                new ApiClients.Models.Requests.ReportApis.GetListDailyInOrderItemRequest
                {
                    UserData = userData,
                }, default);

            if (result.IsSuccess)
            {
                return Json(result.Data);
            }
            else
            {
                return Json(result.ProblemDetails.Detail);
            }

        }
        catch (Exception ex)
        {
            return Json(ex.Message);
        }
    }

    public JsonResult GetListItemMain(DataSourceLoadOptions loadOptions, string userData)
    {
        return Json("ok");
    }
    public async Task<JsonResult> GetListItem(DataSourceLoadOptions loadOptions, string userData)
    {
        try
        {
            var result = await reportApiClient.GetListItemAsync(
                new ApiClients.Models.Requests.ReportApis.GetListItemRequest
                {
                    UserData = userData,
                }, default);

            if (result.IsSuccess)
                return Json(result.Data);

            return Json(result.ProblemDetails.Detail);
        }
        catch (Exception ex)
        {
            return Json(ex.Message);
        }
    }
    public JsonResult GetListChart(DataSourceLoadOptions loadOptions, string userData)
    {
        return Json("ok");
    }

    [HttpGet]
    public object VendorLookup(DataSourceLoadOptions loadOptions)
    {
        return Json("ok");
    }

    public JsonResult GetListChartVen(DataSourceLoadOptions loadOptions, string userData)
    {
        return Json("ok");
    }
    public JsonResult GetListChartVenItem(DataSourceLoadOptions loadOptions, string userData)
    {
        return Json("ok");
    }
    public JsonResult GetListChartItem(DataSourceLoadOptions loadOptions, string userData)
    {
       return Json("ok");
    }
    public JsonResult GetListChartDep(DataSourceLoadOptions loadOptions, string userData)
    {
       return Json("ok");
    }
    public Object GetListOrder(DataSourceLoadOptions loadOptions, int key, int vendorid)
    {
        return Json("ok");
    }
    public async Task<JsonResult> FormAccountPost(ReminderAccount model)
    {

        if (ModelState.IsValid)
        {
            try
            {
                var response = await reminderAccountApiClient.CreateAsync(command: new ReminderAccountCreateRequest
                {
                    AccountGroupId = (int)model.AccountGroupId,
                    Name = model.Name,
                    AccountType = model.AccountType,
                    FinishValue = model.FinishValue,
                    StartValue = model.StartValue,
                }, cancellationToken: CancellationToken.None);

                if (response.IsSuccess)
                {
                    return Json(response.Data);
                }
                return Json("nok");
            }
            catch
            {
                return Json("nok");
            }
        }
        return Json("nok");
    }

    public async Task<JsonResult> FormAccountPut(ReminderAccount model)
    {

        if (ModelState.IsValid)
        {


            try
            {
                var response = await reminderAccountApiClient.UpdateAsync(command: new ReminderAccountUpdateRequest
                {
                    AccountGroupId = (int)model.AccountGroupId,
                    Name = model.Name,
                    AccountType = model.AccountType,
                    FinishValue = model.FinishValue,
                    StartValue = model.StartValue,
                    Id = model.Id,
                }, cancellationToken: CancellationToken.None);

                if (response.IsSuccess
                    )
                {
                    return Json(response.Data);
                }
                return Json("nok");
            }
            catch
            {
                return Json("nok");
            }
        }
        return Json("nok");
    }

    // ToDo: Bilerek kapatıldı FE refactor edilirken yazılacak

    //public JsonResult FormAccountGroupPost(ReminderAccountGroup model)
    //{

    //    if (ModelState.IsValid)
    //    {


    //        model.Save_ReminderAccountGroup();
    //        return Json("ok");
    //    }
    //    return Json("nok");
    //}
    //public JsonResult FormAccountGroupPut(ReminderAccountGroup model)
    //{

    //    if (ModelState.IsValid)
    //    {


    //        var result = model.Update_ReminderAccountGroup();
    //        return Json(result);
    //    }
    //    return Json("nok");
    //}
    //public JsonResult FormRulePost(ReminderRule model)
    //{

    //    if (ModelState.IsValid)
    //    {


    //        model.Save_ReminderRule();
    //        return Json("ok");
    //    }
    //    return Json("nok");
    //}
    //public JsonResult FormRuleJobPost(ReminderRuleJob model)
    //{

    //    if (ModelState.IsValid)
    //    {


    //        model.Save_ReminderRuleJob();
    //        return Json("ok");
    //    }
    //    return Json("nok");
    //}
    //public JsonResult FormRuleJobCompanyPost(ReminderRuleJob model)
    //{

    //    if (ModelState.IsValid)
    //    {
    //        model.Save_ReminderRuleJob();
    //        return Json("ok");
    //    }
    //    return Json("nok");
    //}
}
