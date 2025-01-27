using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DeviceProvisioningServices.v2022_12_12.IotDpsResource;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AllocationPolicyConstant
{
    [Description("GeoLatency")]
    GeoLatency,

    [Description("Hashed")]
    Hashed,

    [Description("Static")]
    Static,
}
