using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MySql.v2021_12_01_preview.FirewallRules;


internal class FirewallRulePropertiesModel
{
    [JsonPropertyName("endIpAddress")]
    [Required]
    public string EndIPAddress { get; set; }

    [JsonPropertyName("startIpAddress")]
    [Required]
    public string StartIPAddress { get; set; }
}