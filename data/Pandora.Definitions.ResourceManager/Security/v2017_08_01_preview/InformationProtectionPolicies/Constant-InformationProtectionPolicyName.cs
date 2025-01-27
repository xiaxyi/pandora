using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Security.v2017_08_01_preview.InformationProtectionPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum InformationProtectionPolicyNameConstant
{
    [Description("custom")]
    Custom,

    [Description("effective")]
    Effective,
}
