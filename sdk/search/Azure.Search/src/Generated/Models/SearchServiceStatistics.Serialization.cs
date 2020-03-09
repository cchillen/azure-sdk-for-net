// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class SearchServiceStatistics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Counters != null)
            {
                writer.WritePropertyName("counters");
                writer.WriteObjectValue(Counters);
            }
            if (Limits != null)
            {
                writer.WritePropertyName("limits");
                writer.WriteObjectValue(Limits);
            }
            writer.WriteEndObject();
        }
        internal static SearchServiceStatistics DeserializeSearchServiceStatistics(JsonElement element)
        {
            SearchServiceStatistics result = new SearchServiceStatistics();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Counters = SearchServiceCounters.DeserializeSearchServiceCounters(property.Value);
                    continue;
                }
                if (property.NameEquals("limits"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Limits = SearchServiceLimits.DeserializeSearchServiceLimits(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}