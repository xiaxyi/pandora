using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Compute.v2021_11_01;
public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2021-11-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new AvailabilitySets.Definition(),
        new CapacityReservation.Definition(),
        new CapacityReservationGroups.Definition(),
        new CapacityReservations.Definition(),
        new Compute.Definition(),
        new DedicatedHost.Definition(),
        new DedicatedHostGroups.Definition(),
        new DedicatedHosts.Definition(),
        new Images.Definition(),
        new LogAnalytics.Definition(),
        new ProximityPlacementGroups.Definition(),
        new RestorePointCollections.Definition(),
        new SshPublicKeys.Definition(),
        new VirtualMachineExtensionImages.Definition(),
        new VirtualMachineExtensions.Definition(),
        new VirtualMachineImages.Definition(),
        new VirtualMachineRunCommands.Definition(),
        new VirtualMachineScaleSetExtensions.Definition(),
        new VirtualMachineScaleSetRollingUpgrades.Definition(),
        new VirtualMachineScaleSetVMExtensions.Definition(),
        new VirtualMachineScaleSetVMRunCommands.Definition(),
        new VirtualMachineScaleSetVMs.Definition(),
        new VirtualMachineScaleSets.Definition(),
        new VirtualMachineSizes.Definition(),
        new VirtualMachines.Definition(),
    };

    public IEnumerable<TerraformResourceDefinition> TerraformResources => new List<TerraformResourceDefinition>
    {
    };
}
