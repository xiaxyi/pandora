// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserContactFolderChildFolderContactExtension;

internal class Definition : ResourceDefinition
{
    public string Name => "UserContactFolderChildFolderContactExtension";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateUserByIdContactFolderByIdChildFolderByIdContactByIdExtensionOperation(),
        new DeleteUserByIdContactFolderByIdChildFolderByIdContactByIdExtensionByIdOperation(),
        new GetUserByIdContactFolderByIdChildFolderByIdContactByIdExtensionByIdOperation(),
        new GetUserByIdContactFolderByIdChildFolderByIdContactByIdExtensionCountOperation(),
        new ListUserByIdContactFolderByIdChildFolderByIdContactByIdExtensionsOperation(),
        new UpdateUserByIdContactFolderByIdChildFolderByIdContactByIdExtensionByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
