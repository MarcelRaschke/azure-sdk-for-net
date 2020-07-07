﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Metadata = System.Collections.Generic.IDictionary<string, string>;
using Tags = System.Collections.Generic.IDictionary<string, string>;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// Optional parameters for creating an Append Blob.
    /// </summary>
    public class AppendBlobCreateOptions
    {
        /// <summary>
        /// Optional standard HTTP header properties that can be set for the
        /// new append blob.
        /// </summary>
        public BlobHttpHeaders HttpHeaders { get; set; }

        /// <summary>
        /// Optional custom metadata to set for this append blob.
        /// </summary>
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Options tags to set for this append blob.
        /// </summary>
        public Tags Tags { get; set; }

        /// <summary>
        /// Optional <see cref="AppendBlobRequestConditions"/> to add
        /// conditions on the creation of this new append blob.
        /// </summary>
        public AppendBlobRequestConditions Conditions { get; set; }
    }
}