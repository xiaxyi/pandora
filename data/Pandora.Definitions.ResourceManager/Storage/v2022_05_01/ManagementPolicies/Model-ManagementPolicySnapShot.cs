using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2022_05_01.ManagementPolicies;


internal class ManagementPolicySnapShotModel
{
    [JsonPropertyName("delete")]
    public DateAfterCreationModel? Delete { get; set; }

    [JsonPropertyName("tierToArchive")]
    public DateAfterCreationModel? TierToArchive { get; set; }

    [JsonPropertyName("tierToCool")]
    public DateAfterCreationModel? TierToCool { get; set; }
}
