using System.Threading;
using System.Threading.Tasks;
using DevExtreme.AspNet.Mvc;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Requests.Daily;
using fincheckup.ApiClients.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace fincheckup.Controllers;

[Route("api/[controller]")]
public class DailyController(IDailyApiClient dailyApiClient) : Controller
{
    
    [HttpGet("GetAll")]
    public async Task<object> GetAll(DataSourceLoadOptions loadOptions, int tyear, CancellationToken cancellationToken)
    {
        return await dailyApiClient.GetListAsync(tyear,new DailyGetListRequest{DataSourceLoadOptions = loadOptions},cancellationToken);
    }

    
    [HttpGet("GetPriority")]
    public async Task<object> GetPriority(DataSourceLoadOptions loadOptions, CancellationToken cancellationToken)
    {
       return await dailyApiClient.GetPriorityAsync(new DailyPrioritytRequest { DataSourceLoadOptions = loadOptions }, cancellationToken);
    }


    [HttpPost]
    public async Task<IActionResult> Post(string values, CancellationToken cancellationToken)
    {
        var newEmployee = new Appointment();
        JsonConvert.PopulateObject(values, newEmployee);
        
        await dailyApiClient.CreateAsync(new DailyCreateRequest{ Model = new AppointmentRequest
        {
            AllDay = newEmployee.AllDay,
            Description = newEmployee.Description,
            EndDate = newEmployee.EndDate,
            PriorityId = newEmployee.PriorityId,
            StartDate = newEmployee.StartDate,
            Status = newEmployee.Status,
            Text = newEmployee.Text
        }}, cancellationToken);
        
        return Ok();
    }

    
    [HttpPut]
    public async Task<IActionResult> Put(int key, string values, CancellationToken cancellationToken)
    {
        var newEmployee = new Appointment();
        JsonConvert.PopulateObject(values, newEmployee);
        
        await dailyApiClient.UpdateAsync(key,new DailyUpdateRequest{Id = key, Model = new AppointmentRequest
        {
            AllDay = newEmployee.AllDay,
            Description = newEmployee.Description,
            EndDate = newEmployee.EndDate,
            PriorityId = newEmployee.PriorityId,
            StartDate = newEmployee.StartDate,
            Status = newEmployee.Status,
            Text = newEmployee.Text
        }}, cancellationToken);

        return Ok();
    }

    
    [HttpDelete]
    public async Task Delete(int key, CancellationToken cancellationToken)
    {
        await dailyApiClient.DeleteAsync(key, cancellationToken);
    }
}
