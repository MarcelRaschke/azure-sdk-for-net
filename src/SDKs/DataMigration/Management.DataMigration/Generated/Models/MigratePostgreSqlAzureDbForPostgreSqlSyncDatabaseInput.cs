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
    using System.Linq;

    /// <summary>
    /// Database specific information for PostgreSQL to Azure Database for
    /// PostgreSQL migration task inputs
    /// </summary>
    public partial class MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseInput class.
        /// </summary>
        public MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseInput class.
        /// </summary>
        /// <param name="name">Name of the database</param>
        /// <param name="targetDatabaseName">Name of target database. Note:
        /// Target database will be truncated before starting
        /// migration.</param>
        public MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseInput(string name = default(string), string targetDatabaseName = default(string))
        {
            Name = name;
            TargetDatabaseName = targetDatabaseName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the database
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets name of target database. Note: Target database will be
        /// truncated before starting migration.
        /// </summary>
        [JsonProperty(PropertyName = "targetDatabaseName")]
        public string TargetDatabaseName { get; set; }

    }
}
