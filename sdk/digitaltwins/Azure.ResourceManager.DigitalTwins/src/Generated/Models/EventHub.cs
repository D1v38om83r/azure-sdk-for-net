// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> properties related to eventhub. </summary>
    public partial class EventHub : DigitalTwinsEndpointResourceProperties
    {
        /// <summary> Initializes a new instance of EventHub. </summary>
        /// <param name="connectionStringPrimaryKey"> PrimaryConnectionString of the endpoint. Will be obfuscated during read. </param>
        /// <param name="connectionStringSecondaryKey"> SecondaryConnectionString of the endpoint. Will be obfuscated during read. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringPrimaryKey"/> or <paramref name="connectionStringSecondaryKey"/> is null. </exception>
        public EventHub(string connectionStringPrimaryKey, string connectionStringSecondaryKey)
        {
            if (connectionStringPrimaryKey == null)
            {
                throw new ArgumentNullException(nameof(connectionStringPrimaryKey));
            }
            if (connectionStringSecondaryKey == null)
            {
                throw new ArgumentNullException(nameof(connectionStringSecondaryKey));
            }

            ConnectionStringPrimaryKey = connectionStringPrimaryKey;
            ConnectionStringSecondaryKey = connectionStringSecondaryKey;
            EndpointType = EndpointType.EventHub;
        }

        /// <summary> Initializes a new instance of EventHub. </summary>
        /// <param name="endpointType"> The type of Digital Twins endpoint. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdTime"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="connectionStringPrimaryKey"> PrimaryConnectionString of the endpoint. Will be obfuscated during read. </param>
        /// <param name="connectionStringSecondaryKey"> SecondaryConnectionString of the endpoint. Will be obfuscated during read. </param>
        internal EventHub(EndpointType endpointType, EndpointProvisioningState? provisioningState, DateTimeOffset? createdTime, IDictionary<string, string> tags, string connectionStringPrimaryKey, string connectionStringSecondaryKey) : base(endpointType, provisioningState, createdTime, tags)
        {
            ConnectionStringPrimaryKey = connectionStringPrimaryKey;
            ConnectionStringSecondaryKey = connectionStringSecondaryKey;
            EndpointType = endpointType;
        }

        /// <summary> PrimaryConnectionString of the endpoint. Will be obfuscated during read. </summary>
        public string ConnectionStringPrimaryKey { get; set; }
        /// <summary> SecondaryConnectionString of the endpoint. Will be obfuscated during read. </summary>
        public string ConnectionStringSecondaryKey { get; set; }
    }
}