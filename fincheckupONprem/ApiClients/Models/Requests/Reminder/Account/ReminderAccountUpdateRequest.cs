using fincheckup.ApiClients.Models.Responses.Reminder.Account;
namespace fincheckup.ApiClients.Models.Requests.Reminder.Account;

public class ReminderAccountUpdateRequest
{
    public required long Id { get; set; }
    public required string Name { get; set; }

    public int StartValue { get; set; }

    public int FinishValue { get; set; }

    public int AccountGroupId { get; set; }

    public int AccountType { get; set; }
}

public class ReminderAccountUpdateQuery
{
    public ReminderAccountUpdateRequest Request { get; set; }
}
