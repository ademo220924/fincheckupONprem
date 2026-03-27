namespace fincheckup.ApiClients.Models.Requests.Reminder;

public class CreateRemainderRuleJobRequest
{
    public long RuleId { get; set; }

    public class CreateRemainderRuleJobQuery
    {
        public CreateRemainderRuleJobRequest Request { get; set; }
    }
}
