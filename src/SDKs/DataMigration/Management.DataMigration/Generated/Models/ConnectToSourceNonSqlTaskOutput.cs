// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output for connect to Oracle, MySQL type source
    /// </summary>
    public partial class ConnectToSourceNonSqlTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the ConnectToSourceNonSqlTaskOutput
        /// class.
        /// </summary>
        public ConnectToSourceNonSqlTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectToSourceNonSqlTaskOutput
        /// class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="sourceServerBrandVersion">Server brand version</param>
        /// <param name="serverProperties">Server properties</param>
        /// <param name="databases">List of databases on the server</param>
        /// <param name="validationErrors">Validation errors associated with
        /// the task</param>
        public ConnectToSourceNonSqlTaskOutput(string id = default(string), string sourceServerBrandVersion = default(string), ServerProperties serverProperties = default(ServerProperties), IList<string> databases = default(IList<string>), IList<ReportableException> validationErrors = default(IList<ReportableException>))
        {
            Id = id;
            SourceServerBrandVersion = sourceServerBrandVersion;
            ServerProperties = serverProperties;
            Databases = databases;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets server brand version
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerBrandVersion")]
        public string SourceServerBrandVersion { get; private set; }

        /// <summary>
        /// Gets server properties
        /// </summary>
        [JsonProperty(PropertyName = "serverProperties")]
        public ServerProperties ServerProperties { get; private set; }

        /// <summary>
        /// Gets list of databases on the server
        /// </summary>
        [JsonProperty(PropertyName = "databases")]
        public IList<string> Databases { get; private set; }

        /// <summary>
        /// Gets validation errors associated with the task
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}
