namespace fincheckup.ApiClients.Models.Requests.Reminder;

public class CreateRemainderRuleRequest
{
    public long AccountId { get; set; }
    public fincheckup.ApiClients.Models.Common.PeriodType PeriodType { get; set; }
    public double ControlValue { get; set; }
    public fincheckup.ApiClients.Models.Common.ControlValueType ControlValueType { get; set; }
}

public class CreateRemainderRuleQuery
{
    public CreateRemainderRuleRequest Request { get; set; }
}
