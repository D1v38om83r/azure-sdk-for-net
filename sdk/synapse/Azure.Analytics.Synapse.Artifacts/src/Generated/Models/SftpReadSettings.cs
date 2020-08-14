// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Sftp read settings. </summary>
    public partial class SftpReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of SftpReadSettings. </summary>
        public SftpReadSettings()
        {
            Type = "SftpReadSettings";
        }

        /// <summary> Initializes a new instance of SftpReadSettings. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> Sftp wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> Sftp wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeStart"> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        internal SftpReadSettings(string type, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object recursive, object wildcardFolderPath, object wildcardFileName, object modifiedDatetimeStart, object modifiedDatetimeEnd) : base(type, maxConcurrentConnections, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            Type = type ?? "SftpReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object Recursive { get; set; }
        /// <summary> Sftp wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public object WildcardFolderPath { get; set; }
        /// <summary> Sftp wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public object WildcardFileName { get; set; }
        /// <summary> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeEnd { get; set; }
    }
}