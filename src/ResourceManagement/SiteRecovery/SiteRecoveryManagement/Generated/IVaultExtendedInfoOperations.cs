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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecoveryVault
{
    /// <summary>
    /// Definition of vault extended info operations for the Site Recovery
    /// extension.
    /// </summary>
    public partial interface IVaultExtendedInfoOperations
    {
        /// <summary>
        /// Get the vault extended info.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the job collection.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
        /// </param>
        /// <param name='extendedInfoArgs'>
        /// Create resource exnteded info input parameters.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateExtendedInfoAsync(string resourceGroupName, string resourceName, ResourceExtendedInformationArgs extendedInfoArgs, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the vault extended info.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the job collection.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the resource extended information object
        /// </returns>
        Task<ResourceExtendedInformationResponse> GetExtendedInfoAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the vault extended info.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the job collection.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
        /// </param>
        /// <param name='extendedInfoArgs'>
        /// Update resource exnteded info input parameters.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the resource extended information object
        /// </returns>
        Task<ResourceExtendedInformationResponse> UpdateExtendedInfoAsync(string resourceGroupName, string resourceName, ResourceExtendedInformationArgs extendedInfoArgs, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the vault extended info.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the job collection.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
        /// </param>
        /// <param name='parameters'>
        /// Upload Vault Certificate input parameters.
        /// </param>
        /// <param name='certFriendlyName'>
        /// Certificate friendly name
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the upload certificate response
        /// </returns>
        Task<UploadCertificateResponse> UploadCertificateAsync(string resourceGroupName, string resourceName, CertificateArgs parameters, string certFriendlyName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
