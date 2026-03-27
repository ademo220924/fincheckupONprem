
namespace fincheckup.ApiClients.Models.Requests.Daily;

public class DailyCreateRequest
{
    public AppointmentRequest Model { get; set; }
}

public class DailyCreateQuery
{
    public DailyCreateRequest Request { get; set; }
}
