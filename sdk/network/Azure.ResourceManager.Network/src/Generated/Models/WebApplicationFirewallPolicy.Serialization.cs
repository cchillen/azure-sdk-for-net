// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class WebApplicationFirewallPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (PolicySettings != null)
            {
                writer.WritePropertyName("policySettings");
                writer.WriteObjectValue(PolicySettings);
            }
            if (CustomRules != null)
            {
                writer.WritePropertyName("customRules");
                writer.WriteStartArray();
                foreach (var item in CustomRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ApplicationGateways != null)
            {
                writer.WritePropertyName("applicationGateways");
                writer.WriteStartArray();
                foreach (var item in ApplicationGateways)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (ResourceState != null)
            {
                writer.WritePropertyName("resourceState");
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (ManagedRules != null)
            {
                writer.WritePropertyName("managedRules");
                writer.WriteObjectValue(ManagedRules);
            }
            if (HttpListeners != null)
            {
                writer.WritePropertyName("httpListeners");
                writer.WriteStartArray();
                foreach (var item in HttpListeners)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PathBasedRules != null)
            {
                writer.WritePropertyName("pathBasedRules");
                writer.WriteStartArray();
                foreach (var item in PathBasedRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebApplicationFirewallPolicy DeserializeWebApplicationFirewallPolicy(JsonElement element)
        {
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            PolicySettings policySettings = default;
            IList<WebApplicationFirewallCustomRule> customRules = default;
            IList<ApplicationGateway> applicationGateways = default;
            ProvisioningState? provisioningState = default;
            WebApplicationFirewallPolicyResourceState? resourceState = default;
            ManagedRulesDefinition managedRules = default;
            IList<SubResource> httpListeners = default;
            IList<SubResource> pathBasedRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policySettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policySettings = PolicySettings.DeserializePolicySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WebApplicationFirewallCustomRule> array = new List<WebApplicationFirewallCustomRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(WebApplicationFirewallCustomRule.DeserializeWebApplicationFirewallCustomRule(item));
                                }
                            }
                            customRules = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationGateways"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationGateway> array = new List<ApplicationGateway>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ApplicationGateway.DeserializeApplicationGateway(item));
                                }
                            }
                            applicationGateways = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new WebApplicationFirewallPolicyResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedRules = ManagedRulesDefinition.DeserializeManagedRulesDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpListeners"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(SubResource.DeserializeSubResource(item));
                                }
                            }
                            httpListeners = array;
                            continue;
                        }
                        if (property0.NameEquals("pathBasedRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(SubResource.DeserializeSubResource(item));
                                }
                            }
                            pathBasedRules = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebApplicationFirewallPolicy(id, name, type, location, tags, etag, policySettings, customRules, applicationGateways, provisioningState, resourceState, managedRules, httpListeners, pathBasedRules);
        }
    }
}