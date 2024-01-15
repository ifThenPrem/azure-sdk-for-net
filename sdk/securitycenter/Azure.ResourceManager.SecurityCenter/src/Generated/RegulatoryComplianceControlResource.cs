// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a RegulatoryComplianceControl along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RegulatoryComplianceControlResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRegulatoryComplianceControlResource method.
    /// Otherwise you can get one from its parent resource <see cref="RegulatoryComplianceStandardResource"/> using the GetRegulatoryComplianceControl method.
    /// </summary>
    public partial class RegulatoryComplianceControlResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RegulatoryComplianceControlResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="regulatoryComplianceStandardName"> The regulatoryComplianceStandardName. </param>
        /// <param name="regulatoryComplianceControlName"> The regulatoryComplianceControlName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string regulatoryComplianceStandardName, string regulatoryComplianceControlName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _regulatoryComplianceControlClientDiagnostics;
        private readonly RegulatoryComplianceControlsRestOperations _regulatoryComplianceControlRestClient;
        private readonly RegulatoryComplianceControlData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/regulatoryComplianceStandards/regulatoryComplianceControls";

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceControlResource"/> class for mocking. </summary>
        protected RegulatoryComplianceControlResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RegulatoryComplianceControlResource(ArmClient client, RegulatoryComplianceControlData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RegulatoryComplianceControlResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _regulatoryComplianceControlClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string regulatoryComplianceControlApiVersion);
            _regulatoryComplianceControlRestClient = new RegulatoryComplianceControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, regulatoryComplianceControlApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RegulatoryComplianceControlData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of RegulatoryComplianceAssessmentResources in the RegulatoryComplianceControl. </summary>
        /// <returns> An object representing collection of RegulatoryComplianceAssessmentResources and their operations over a RegulatoryComplianceAssessmentResource. </returns>
        public virtual RegulatoryComplianceAssessmentCollection GetRegulatoryComplianceAssessments()
        {
            return GetCachedClient(client => new RegulatoryComplianceAssessmentCollection(client, Id));
        }

        /// <summary>
        /// Supported regulatory compliance details and state for selected assessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegulatoryComplianceAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceAssessmentName"> Name of the regulatory compliance assessment object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceAssessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RegulatoryComplianceAssessmentResource>> GetRegulatoryComplianceAssessmentAsync(string regulatoryComplianceAssessmentName, CancellationToken cancellationToken = default)
        {
            return await GetRegulatoryComplianceAssessments().GetAsync(regulatoryComplianceAssessmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Supported regulatory compliance details and state for selected assessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}/regulatoryComplianceAssessments/{regulatoryComplianceAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceAssessments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegulatoryComplianceAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceAssessmentName"> Name of the regulatory compliance assessment object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceAssessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RegulatoryComplianceAssessmentResource> GetRegulatoryComplianceAssessment(string regulatoryComplianceAssessmentName, CancellationToken cancellationToken = default)
        {
            return GetRegulatoryComplianceAssessments().Get(regulatoryComplianceAssessmentName, cancellationToken);
        }

        /// <summary>
        /// Selected regulatory compliance control details and state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegulatoryComplianceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegulatoryComplianceControlResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _regulatoryComplianceControlClientDiagnostics.CreateScope("RegulatoryComplianceControlResource.Get");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceControlRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Selected regulatory compliance control details and state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegulatoryComplianceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegulatoryComplianceControlResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _regulatoryComplianceControlClientDiagnostics.CreateScope("RegulatoryComplianceControlResource.Get");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceControlRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
