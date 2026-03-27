namespace fincheckup.ApiClients.Models.Requests.Reminder.Account;

public class ReminderAccountCreateRequest
{
    public required string Name { get; set; }

    public int StartValue { get; set; }

    public int FinishValue { get; set; }

    public int AccountGroupId { get; set; }

    public int AccountType { get; set; }
}

public class ReminderAccountCreateQuery
{
    public ReminderAccountCreateRequest Request { get; set; }
}
