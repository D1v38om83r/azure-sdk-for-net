// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class DataFeedMetric : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("metricName");
            writer.WriteStringValue(MetricName);
            if (Optional.IsDefined(MetricDisplayName))
            {
                writer.WritePropertyName("metricDisplayName");
                writer.WriteStringValue(MetricDisplayName);
            }
            if (Optional.IsDefined(MetricDescription))
            {
                writer.WritePropertyName("metricDescription");
                writer.WriteStringValue(MetricDescription);
            }
            writer.WriteEndObject();
        }

        internal static DataFeedMetric DeserializeDataFeedMetric(JsonElement element)
        {
            Optional<string> metricId = default;
            string metricName = default;
            Optional<string> metricDisplayName = default;
            Optional<string> metricDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricId"))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricName"))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricDisplayName"))
                {
                    metricDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricDescription"))
                {
                    metricDescription = property.Value.GetString();
                    continue;
                }
            }
            return new DataFeedMetric(metricId.Value, metricName, metricDisplayName.Value, metricDescription.Value);
        }
    }
}
