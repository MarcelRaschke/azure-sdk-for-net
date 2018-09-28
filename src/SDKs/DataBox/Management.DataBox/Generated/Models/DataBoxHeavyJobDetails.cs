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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Databox Heavy Device Job Details
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataBoxHeavy")]
    public partial class DataBoxHeavyJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxHeavyJobDetails class.
        /// </summary>
        public DataBoxHeavyJobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxHeavyJobDetails class.
        /// </summary>
        /// <param name="contactDetails">Contact details for notification and
        /// shipping.</param>
        /// <param name="shippingAddress">Shipping address of the
        /// customer.</param>
        /// <param name="destinationAccountDetails">Destination account
        /// details.</param>
        /// <param name="expectedDataSizeInTeraBytes">The expected size of the
        /// data, which needs to be transfered in this job, in tera
        /// bytes.</param>
        /// <param name="jobStages">List of stages that run in the job.</param>
        /// <param name="deliveryPackage">Delivery package shipping
        /// details.</param>
        /// <param name="returnPackage">Return package shipping
        /// details.</param>
        /// <param name="errorDetails">Error details for failure. This is
        /// optional.</param>
        /// <param name="preferences">Preferences for the order.</param>
        /// <param name="copyLogDetails">List of copy log details.</param>
        /// <param name="reverseShipmentLabelSasKey">Shared access key to
        /// download the return shipment label</param>
        /// <param name="chainOfCustodySasKey">Shared access key to download
        /// the chain of custody logs</param>
        /// <param name="copyProgress">Copy progress per account.</param>
        public DataBoxHeavyJobDetails(ContactDetails contactDetails, ShippingAddress shippingAddress, IList<DestinationAccountDetails> destinationAccountDetails, int? expectedDataSizeInTeraBytes = default(int?), IList<JobStages> jobStages = default(IList<JobStages>), PackageShippingDetails deliveryPackage = default(PackageShippingDetails), PackageShippingDetails returnPackage = default(PackageShippingDetails), IList<JobErrorDetails> errorDetails = default(IList<JobErrorDetails>), Preferences preferences = default(Preferences), IList<CopyLogDetails> copyLogDetails = default(IList<CopyLogDetails>), string reverseShipmentLabelSasKey = default(string), string chainOfCustodySasKey = default(string), IList<CopyProgress> copyProgress = default(IList<CopyProgress>))
            : base(contactDetails, shippingAddress, destinationAccountDetails, expectedDataSizeInTeraBytes, jobStages, deliveryPackage, returnPackage, errorDetails, preferences, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey)
        {
            CopyProgress = copyProgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets copy progress per account.
        /// </summary>
        [JsonProperty(PropertyName = "copyProgress")]
        public IList<CopyProgress> CopyProgress { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
