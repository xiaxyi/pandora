using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AppConfiguration.v2023_03_01.PrivateEndpointConnections;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ActionsRequiredConstant
{
    [Description("None")]
    None,

    [Description("Recreate")]
    Recreate,
}
