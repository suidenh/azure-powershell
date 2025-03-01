// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// RestorableDatabaseAccountsOperations operations.
    /// </summary>
    public partial interface IRestorableDatabaseAccountsOperations
    {
        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &#39;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&#39; permission.
        /// </summary>
        /// <remarks>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &#39;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&#39; permission.
        /// </remarks>
        /// <param name='location'>
        /// Cosmos DB region, with spaces between words and each word capitalized.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<System.Collections.Generic.IEnumerable<RestorableDatabaseAccountGetResult>>> ListByLocationWithHttpMessagesAsync(string location, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription. This call requires &#39;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&#39; permission.
        /// </summary>
        /// <remarks>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription. This call requires &#39;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&#39; permission.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<System.Collections.Generic.IEnumerable<RestorableDatabaseAccountGetResult>>> ListWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &#39;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&#39; permission.
        /// </summary>
        /// <remarks>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &#39;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&#39; permission.
        /// </remarks>
        /// <param name='location'>
        /// Cosmos DB region, with spaces between words and each word capitalized.
        /// </param>
        /// <param name='instanceId'>
        /// The instanceId GUID of a restorable database account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<RestorableDatabaseAccountGetResult>> GetByLocationWithHttpMessagesAsync(string location, string instanceId, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}