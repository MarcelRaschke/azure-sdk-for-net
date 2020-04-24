// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Resource.Models;

namespace Azure.Management.Resource
{
    /// <summary> The Deployment service client. </summary>
    public partial class DeploymentClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DeploymentRestClient RestClient { get; }
        /// <summary> Initializes a new instance of DeploymentClient for mocking. </summary>
        protected DeploymentClient()
        {
        }

        /// <summary> Initializes a new instance of DeploymentClient. </summary>
        public DeploymentClient(string subscriptionId, TokenCredential tokenCredential, ResourceManagementClientOptions options = null)
        {
            options = options ?? new ResourceManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new DeploymentRestClient(_clientDiagnostics, _pipeline, subscriptionId, apiVersion: options.Version);
        }

        /// <summary> Get a list of deployments operations. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentOperation>> GetAsync(string resourceGroupName, string deploymentName, string operationId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, deploymentName, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get a list of deployments operations. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentOperation> Get(string resourceGroupName, string deploymentName, string operationId, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, deploymentName, operationId, cancellationToken);
        }

        /// <summary> Gets a list of deployments operations. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="top"> Query parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DeploymentOperation> ListAsync(string resourceGroupName, string deploymentName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            async Task<Page<DeploymentOperation>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(resourceGroupName, deploymentName, top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<DeploymentOperation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, deploymentName, top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of deployments operations. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="top"> Query parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DeploymentOperation> List(string resourceGroupName, string deploymentName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            Page<DeploymentOperation> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(resourceGroupName, deploymentName, top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<DeploymentOperation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, resourceGroupName, deploymentName, top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}