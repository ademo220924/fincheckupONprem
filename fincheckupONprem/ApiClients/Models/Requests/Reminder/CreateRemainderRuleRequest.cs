using fincheckup.Models.EarlyWarning.Response;

namespace fincheckup.ApiClients.Models.Requests.Reminder;

public class CreateRemainderRuleRequest
{
    public long AccountId { get; set; }
    public PeriodType PeriodType { get; set; }
    public double ControlValue { get; set; }
    public ControlValueType ControlValueType { get; set; }
}
