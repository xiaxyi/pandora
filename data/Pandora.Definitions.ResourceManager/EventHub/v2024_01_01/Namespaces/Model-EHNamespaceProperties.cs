using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.EventHub.v2024_01_01.Namespaces;


internal class EHNamespacePropertiesModel
{
    [JsonPropertyName("alternateName")]
    public string? AlternateName { get; set; }

    [JsonPropertyName("clusterArmId")]
    public string? ClusterArmId { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("encryption")]
    public EncryptionModel? Encryption { get; set; }

    [JsonPropertyName("isAutoInflateEnabled")]
    public bool? IsAutoInflateEnabled { get; set; }

    [JsonPropertyName("kafkaEnabled")]
    public bool? KafkaEnabled { get; set; }

    [JsonPropertyName("maximumThroughputUnits")]
    public int? MaximumThroughputUnits { get; set; }

    [JsonPropertyName("metricId")]
    public string? MetricId { get; set; }

    [JsonPropertyName("minimumTlsVersion")]
    public TlsVersionConstant? MinimumTlsVersion { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public List<PrivateEndpointConnectionModel>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public PublicNetworkAccessConstant? PublicNetworkAccess { get; set; }

    [JsonPropertyName("serviceBusEndpoint")]
    public string? ServiceBusEndpoint { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}
