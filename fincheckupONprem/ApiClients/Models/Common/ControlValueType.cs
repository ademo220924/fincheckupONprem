using System.ComponentModel;

namespace fincheckup.ApiClients.Models.Common;

public enum ControlValueType
{
    [Description("Artmıştır")] Increment = 1,
    [Description("Azalmıştır")] Decrease = 2
}