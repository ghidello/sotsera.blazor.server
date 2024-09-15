// Copyright (c) Alessandro Ghidini. All rights reserved.
// SPDX-License-Identifier: MIT.

using Sotsera.Blazor.Server.SecurityHeaders.Policies.Permissions.Directives.Base;

namespace Sotsera.Blazor.Server.SecurityHeaders.Policies.Permissions.Directives;

public class EncryptedMedia() : PermissionsPolicyDirective("encrypted-media")
{
    public static implicit operator EncryptedMedia(string value) => new() { Value = value };
}
