using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Kusto.v2023_08_15.Databases;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CallerRoleConstant
{
    [Description("Admin")]
    Admin,

    [Description("None")]
    None,
}
