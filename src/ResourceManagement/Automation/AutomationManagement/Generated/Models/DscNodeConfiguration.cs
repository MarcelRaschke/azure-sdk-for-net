// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the dsc node configuration.
    /// </summary>
    public partial class DscNodeConfiguration
    {
        private DscConfigurationAssociationProperty _configuration;
        
        /// <summary>
        /// Optional. Gets or sets the configuration of the node.
        /// </summary>
        public DscConfigurationAssociationProperty Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }
        
        private DateTimeOffset _creationTime;
        
        /// <summary>
        /// Optional. Gets or sets creation time.
        /// </summary>
        public DateTimeOffset CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }
        
        private DateTimeOffset _lastModifiedTime;
        
        /// <summary>
        /// Optional. Gets or sets the last modified time.
        /// </summary>
        public DateTimeOffset LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the node configuration name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscNodeConfiguration class.
        /// </summary>
        public DscNodeConfiguration()
        {
        }
    }
}
