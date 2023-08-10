using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2023_01_01.BlobContainers;

internal class CreateOrUpdateImmutabilityPolicyOperation : Pandora.Definitions.Operations.PutOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(ImmutabilityPolicyModel);

    public override ResourceID? ResourceId() => new StorageContainerId();

    public override Type? ResponseObject() => typeof(ImmutabilityPolicyModel);

    public override Type? OptionsObject() => typeof(CreateOrUpdateImmutabilityPolicyOperation.CreateOrUpdateImmutabilityPolicyOptions);

    public override string? UriSuffix() => "/immutabilityPolicies/default";

    internal class CreateOrUpdateImmutabilityPolicyOptions
    {
        [HeaderName("If-Match")]
        [Optional]
        public string IfMatch { get; set; }
    }
}
