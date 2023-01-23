using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2022_05_15.CosmosDB;

internal class CollectionPartitionKeyRangeIdId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{databaseAccountName}/region/{regionName}/databases/{databaseName}/collections/{collectionName}/partitionKeyRangeId/{partitionKeyRangeId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftDocumentDB", "Microsoft.DocumentDB"),
        ResourceIDSegment.Static("staticDatabaseAccounts", "databaseAccounts"),
        ResourceIDSegment.UserSpecified("databaseAccountName"),
        ResourceIDSegment.Static("staticRegion", "region"),
        ResourceIDSegment.UserSpecified("regionName"),
        ResourceIDSegment.Static("staticDatabases", "databases"),
        ResourceIDSegment.UserSpecified("databaseName"),
        ResourceIDSegment.Static("staticCollections", "collections"),
        ResourceIDSegment.UserSpecified("collectionName"),
        ResourceIDSegment.Static("staticPartitionKeyRangeId", "partitionKeyRangeId"),
        ResourceIDSegment.UserSpecified("partitionKeyRangeId"),
    };
}
