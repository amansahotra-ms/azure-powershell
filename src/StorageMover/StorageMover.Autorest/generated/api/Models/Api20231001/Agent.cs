// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    /// <summary>The Agent resource.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.DoNotFormat]
    public partial class Agent :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgent,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.Resource();

        /// <summary>The Agent status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? AgentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).AgentStatus; }

        /// <summary>The fully qualified resource ID of the Hybrid Compute resource for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string ArcResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ArcResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ArcResourceId = value ; }

        /// <summary>The VM UUID of the Hybrid Compute resource for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string ArcVMUuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ArcVMUuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ArcVMUuid = value ; }

        /// <summary>A description for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Error code reported by Agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ErrorDetailCode = value ?? null; }

        /// <summary>Expanded description of reported error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ErrorDetailMessage = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>The last updated time of the Agent status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastStatusUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).LastStatusUpdate; }

        /// <summary>Local IP address reported by the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string LocalIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).LocalIPAddress; }

        /// <summary>Available memory reported by the Agent, in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public long? MemoryInMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).MemoryInMb; }

        /// <summary>Internal Acessors for AgentStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.AgentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).AgentStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).AgentStatus = value; }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetails Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ErrorDetail = value; }

        /// <summary>Internal Acessors for LastStatusUpdate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.LastStatusUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).LastStatusUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).LastStatusUpdate = value; }

        /// <summary>Internal Acessors for LocalIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.LocalIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).LocalIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).LocalIPAddress = value; }

        /// <summary>Internal Acessors for MemoryInMb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.MemoryInMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).MemoryInMb; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).MemoryInMb = value; }

        /// <summary>Internal Acessors for NumberOfCores</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.NumberOfCores { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).NumberOfCore; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).NumberOfCore = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentProperties Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.AgentProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for UptimeInSeconds</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.UptimeInSeconds { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).UptimeInSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).UptimeInSecond = value; }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentInternal.Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).AgentVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).AgentVersion = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Available compute cores reported by the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public long? NumberOfCores { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).NumberOfCore; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.AgentProperties()); set => this._property = value; }

        /// <summary>The provisioning state of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Uptime of the Agent in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public long? UptimeInSeconds { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).UptimeInSecond; }

        /// <summary>The Agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal)Property).AgentVersion; }

        /// <summary>Creates an new <see cref="Agent" /> instance.</summary>
        public Agent()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The Agent resource.
    public partial interface IAgent :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResource
    {
        /// <summary>The Agent status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Agent status.",
        SerializedName = @"agentStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? AgentStatus { get;  }
        /// <summary>The fully qualified resource ID of the Hybrid Compute resource for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The fully qualified resource ID of the Hybrid Compute resource for the Agent.",
        SerializedName = @"arcResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ArcResourceId { get; set; }
        /// <summary>The VM UUID of the Hybrid Compute resource for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The VM UUID of the Hybrid Compute resource for the Agent.",
        SerializedName = @"arcVmUuid",
        PossibleTypes = new [] { typeof(string) })]
        string ArcVMUuid { get; set; }
        /// <summary>A description for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description for the Agent.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Error code reported by Agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error code reported by Agent",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailCode { get; set; }
        /// <summary>Expanded description of reported error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Expanded description of reported error code",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailMessage { get; set; }
        /// <summary>The last updated time of the Agent status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last updated time of the Agent status.",
        SerializedName = @"lastStatusUpdate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastStatusUpdate { get;  }
        /// <summary>Local IP address reported by the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Local IP address reported by the Agent.",
        SerializedName = @"localIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string LocalIPAddress { get;  }
        /// <summary>Available memory reported by the Agent, in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Available memory reported by the Agent, in MB.",
        SerializedName = @"memoryInMB",
        PossibleTypes = new [] { typeof(long) })]
        long? MemoryInMb { get;  }
        /// <summary>Available compute cores reported by the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Available compute cores reported by the Agent.",
        SerializedName = @"numberOfCores",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfCores { get;  }
        /// <summary>The provisioning state of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of this resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Uptime of the Agent in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Uptime of the Agent in seconds.",
        SerializedName = @"uptimeInSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long? UptimeInSeconds { get;  }
        /// <summary>The Agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Agent version.",
        SerializedName = @"agentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// The Agent resource.
    internal partial interface IAgentInternal :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api30.IResourceInternal
    {
        /// <summary>The Agent status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? AgentStatus { get; set; }
        /// <summary>The fully qualified resource ID of the Hybrid Compute resource for the Agent.</summary>
        string ArcResourceId { get; set; }
        /// <summary>The VM UUID of the Hybrid Compute resource for the Agent.</summary>
        string ArcVMUuid { get; set; }
        /// <summary>A description for the Agent.</summary>
        string Description { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetails ErrorDetail { get; set; }
        /// <summary>Error code reported by Agent</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>Expanded description of reported error code</summary>
        string ErrorDetailMessage { get; set; }
        /// <summary>The last updated time of the Agent status.</summary>
        global::System.DateTime? LastStatusUpdate { get; set; }
        /// <summary>Local IP address reported by the Agent.</summary>
        string LocalIPAddress { get; set; }
        /// <summary>Available memory reported by the Agent, in MB.</summary>
        long? MemoryInMb { get; set; }
        /// <summary>Available compute cores reported by the Agent.</summary>
        long? NumberOfCores { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentProperties Property { get; set; }
        /// <summary>The provisioning state of this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Uptime of the Agent in seconds.</summary>
        long? UptimeInSeconds { get; set; }
        /// <summary>The Agent version.</summary>
        string Version { get; set; }

    }
}