using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AlertsManagement.v2019_05_05_preview.AlertsManagements;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SignalTypeConstant
{
    [Description("Log")]
    Log,

    [Description("Metric")]
    Metric,

    [Description("Unknown")]
    Unknown,
}
