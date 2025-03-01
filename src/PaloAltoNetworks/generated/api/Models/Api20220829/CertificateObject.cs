// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Extensions;

    /// <summary>certificate used for inbound and outbound decryption</summary>
    public partial class CertificateObject :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.ICertificateObject,
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.ICertificateObjectInternal
    {

        /// <summary>Backing field for <see cref="AuditComment" /> property.</summary>
        private string _auditComment;

        /// <summary>comment for this object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string AuditComment { get => this._auditComment; set => this._auditComment = value; }

        /// <summary>Backing field for <see cref="CertificateSelfSigned" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.BooleanEnum _certificateSelfSigned;

        /// <summary>use certificate self signed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.BooleanEnum CertificateSelfSigned { get => this._certificateSelfSigned; set => this._certificateSelfSigned = value; }

        /// <summary>Backing field for <see cref="CertificateSignerResourceId" /> property.</summary>
        private string _certificateSignerResourceId;

        /// <summary>
        /// Resource Id of certificate signer, to be populated only when certificateSelfSigned is false
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string CertificateSignerResourceId { get => this._certificateSignerResourceId; set => this._certificateSignerResourceId = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>user description for this object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>read only string representing last create or update</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; set => this._etag = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.ICertificateObjectInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="CertificateObject" /> instance.</summary>
        public CertificateObject()
        {

        }
    }
    /// certificate used for inbound and outbound decryption
    public partial interface ICertificateObject :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.IJsonSerializable
    {
        /// <summary>comment for this object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"comment for this object",
        SerializedName = @"auditComment",
        PossibleTypes = new [] { typeof(string) })]
        string AuditComment { get; set; }
        /// <summary>use certificate self signed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"use certificate self signed",
        SerializedName = @"certificateSelfSigned",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.BooleanEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.BooleanEnum CertificateSelfSigned { get; set; }
        /// <summary>
        /// Resource Id of certificate signer, to be populated only when certificateSelfSigned is false
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id of certificate signer, to be populated only when certificateSelfSigned is false",
        SerializedName = @"certificateSignerResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateSignerResourceId { get; set; }
        /// <summary>user description for this object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"user description for this object",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>read only string representing last create or update</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"read only string representing last create or update",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// certificate used for inbound and outbound decryption
    internal partial interface ICertificateObjectInternal

    {
        /// <summary>comment for this object</summary>
        string AuditComment { get; set; }
        /// <summary>use certificate self signed</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.BooleanEnum CertificateSelfSigned { get; set; }
        /// <summary>
        /// Resource Id of certificate signer, to be populated only when certificateSelfSigned is false
        /// </summary>
        string CertificateSignerResourceId { get; set; }
        /// <summary>user description for this object</summary>
        string Description { get; set; }
        /// <summary>read only string representing last create or update</summary>
        string Etag { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}