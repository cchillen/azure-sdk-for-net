// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.AccessControl.Models
{
    public partial class RoleAssignmentDetails
    {
        internal static RoleAssignmentDetails DeserializeRoleAssignmentDetails(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> roleId = default;
            Optional<string> principalId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleId"))
                {
                    roleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
            }
            return new RoleAssignmentDetails(id.Value, roleId.Value, principalId.Value);
        }
    }
}
