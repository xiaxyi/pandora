// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class MachineLearningDetectedSensitiveContentModel
{
    [JsonPropertyName("classificationAttributes")]
    public List<ClassificationAttributeModel>? ClassificationAttributes { get; set; }

    [JsonPropertyName("classificationMethod")]
    public MachineLearningDetectedSensitiveContentClassificationMethodConstant? ClassificationMethod { get; set; }

    [JsonPropertyName("confidence")]
    public int? Confidence { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("matchTolerance")]
    public MachineLearningDetectedSensitiveContentMatchToleranceConstant? MatchTolerance { get; set; }

    [JsonPropertyName("matches")]
    public List<SensitiveContentLocationModel>? Matches { get; set; }

    [JsonPropertyName("modelVersion")]
    public string? ModelVersion { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("recommendedConfidence")]
    public int? RecommendedConfidence { get; set; }

    [JsonPropertyName("scope")]
    public MachineLearningDetectedSensitiveContentScopeConstant? Scope { get; set; }

    [JsonPropertyName("sensitiveTypeSource")]
    public MachineLearningDetectedSensitiveContentSensitiveTypeSourceConstant? SensitiveTypeSource { get; set; }

    [JsonPropertyName("uniqueCount")]
    public int? UniqueCount { get; set; }
}
