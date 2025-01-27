using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Cognitive.v2023_05_01.Deployments;

internal class Definition : ResourceDefinition
{
    public string Name => "Deployments";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(DeploymentModelVersionUpgradeOptionConstant),
        typeof(DeploymentProvisioningStateConstant),
        typeof(DeploymentScaleTypeConstant),
        typeof(SkuTierConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CallRateLimitModel),
        typeof(DeploymentModel),
        typeof(DeploymentModelModel),
        typeof(DeploymentPropertiesModel),
        typeof(DeploymentScaleSettingsModel),
        typeof(RequestMatchPatternModel),
        typeof(SkuModel),
        typeof(ThrottlingRuleModel),
    };
}
