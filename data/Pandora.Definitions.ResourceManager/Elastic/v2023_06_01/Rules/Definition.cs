using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Elastic.v2023_06_01.Rules;

internal class Definition : ResourceDefinition
{
    public string Name => "Rules";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new TagRulesCreateOrUpdateOperation(),
        new TagRulesDeleteOperation(),
        new TagRulesGetOperation(),
        new TagRulesListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningStateConstant),
        typeof(TagActionConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(FilteringTagModel),
        typeof(LogRulesModel),
        typeof(MonitoringTagRulesModel),
        typeof(MonitoringTagRulesPropertiesModel),
    };
}
