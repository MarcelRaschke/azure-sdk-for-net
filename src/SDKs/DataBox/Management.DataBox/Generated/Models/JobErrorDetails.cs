// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Job Error Details for providing the information and recommended action.
    /// </summary>
    public partial class JobErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        public JobErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        /// <param name="errorMessage">Message for the error.</param>
        /// <param name="errorCode">Code for the error.</param>
        /// <param name="recommendedAction">Recommended action for the
        /// error.</param>
        /// <param name="exceptionMessage">Contains the non localized exception
        /// message</param>
        public JobErrorDetails(string errorMessage = default(string), int? errorCode = default(int?), string recommendedAction = default(string), string exceptionMessage = default(string))
        {
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
            RecommendedAction = recommendedAction;
            ExceptionMessage = exceptionMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets message for the error.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets code for the error.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; private set; }

        /// <summary>
        /// Gets recommended action for the error.
        /// </summary>
        [JsonProperty(PropertyName = "recommendedAction")]
        public string RecommendedAction { get; private set; }

        /// <summary>
        /// Gets contains the non localized exception message
        /// </summary>
        [JsonProperty(PropertyName = "exceptionMessage")]
        public string ExceptionMessage { get; private set; }

    }
}
