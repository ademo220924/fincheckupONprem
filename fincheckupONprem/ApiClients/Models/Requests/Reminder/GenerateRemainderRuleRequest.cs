using fincheckup.ApiClients.Entities.BgServer;
using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Requests.Reminder;

public class GenerateRemainderRuleRequest
{
    public List<ReminderRule> ReminderRules { get; set; }
}
