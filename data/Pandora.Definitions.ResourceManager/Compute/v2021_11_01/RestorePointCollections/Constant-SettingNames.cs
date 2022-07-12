using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2021_11_01.RestorePointCollections;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SettingNamesConstant
{
    [Description("AutoLogon")]
    AutoLogon,

    [Description("FirstLogonCommands")]
    FirstLogonCommands,
}
