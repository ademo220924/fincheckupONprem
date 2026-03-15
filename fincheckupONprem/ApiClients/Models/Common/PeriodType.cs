using System.ComponentModel;

namespace fincheckup.ApiClients.Models.Common;

public enum PeriodType
{
    [Description("Monthly")] Monthly = 1,
    [Description("Quarterly")] Quarterly = 2,
    [Description("Yearly")] Yearly = 3
}