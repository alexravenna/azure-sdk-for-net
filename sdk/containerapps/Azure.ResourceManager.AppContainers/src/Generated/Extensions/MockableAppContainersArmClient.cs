// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableAppContainersArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAppContainersArmClient"/> class for mocking. </summary>
        protected MockableAppContainersArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppContainersArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppContainersArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableAppContainersArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppAuthConfigResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppAuthConfigResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppAuthConfigResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppAuthConfigResource"/> object. </returns>
        public virtual ContainerAppAuthConfigResource GetContainerAppAuthConfigResource(ResourceIdentifier id)
        {
            ContainerAppAuthConfigResource.ValidateResourceId(id);
            return new ContainerAppAuthConfigResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppConnectedEnvironmentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppConnectedEnvironmentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppConnectedEnvironmentResource"/> object. </returns>
        public virtual ContainerAppConnectedEnvironmentResource GetContainerAppConnectedEnvironmentResource(ResourceIdentifier id)
        {
            ContainerAppConnectedEnvironmentResource.ValidateResourceId(id);
            return new ContainerAppConnectedEnvironmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppConnectedEnvironmentCertificateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppConnectedEnvironmentCertificateResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppConnectedEnvironmentCertificateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppConnectedEnvironmentCertificateResource"/> object. </returns>
        public virtual ContainerAppConnectedEnvironmentCertificateResource GetContainerAppConnectedEnvironmentCertificateResource(ResourceIdentifier id)
        {
            ContainerAppConnectedEnvironmentCertificateResource.ValidateResourceId(id);
            return new ContainerAppConnectedEnvironmentCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppManagedEnvironmentCertificateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppManagedEnvironmentCertificateResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppManagedEnvironmentCertificateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppManagedEnvironmentCertificateResource"/> object. </returns>
        public virtual ContainerAppManagedEnvironmentCertificateResource GetContainerAppManagedEnvironmentCertificateResource(ResourceIdentifier id)
        {
            ContainerAppManagedEnvironmentCertificateResource.ValidateResourceId(id);
            return new ContainerAppManagedEnvironmentCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppConnectedEnvironmentDaprComponentResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppConnectedEnvironmentDaprComponentResource"/> object. </returns>
        public virtual ContainerAppConnectedEnvironmentDaprComponentResource GetContainerAppConnectedEnvironmentDaprComponentResource(ResourceIdentifier id)
        {
            ContainerAppConnectedEnvironmentDaprComponentResource.ValidateResourceId(id);
            return new ContainerAppConnectedEnvironmentDaprComponentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppManagedEnvironmentDaprComponentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppManagedEnvironmentDaprComponentResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppManagedEnvironmentDaprComponentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppManagedEnvironmentDaprComponentResource"/> object. </returns>
        public virtual ContainerAppManagedEnvironmentDaprComponentResource GetContainerAppManagedEnvironmentDaprComponentResource(ResourceIdentifier id)
        {
            ContainerAppManagedEnvironmentDaprComponentResource.ValidateResourceId(id);
            return new ContainerAppManagedEnvironmentDaprComponentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppConnectedEnvironmentStorageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppConnectedEnvironmentStorageResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppConnectedEnvironmentStorageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppConnectedEnvironmentStorageResource"/> object. </returns>
        public virtual ContainerAppConnectedEnvironmentStorageResource GetContainerAppConnectedEnvironmentStorageResource(ResourceIdentifier id)
        {
            ContainerAppConnectedEnvironmentStorageResource.ValidateResourceId(id);
            return new ContainerAppConnectedEnvironmentStorageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppResource"/> object. </returns>
        public virtual ContainerAppResource GetContainerAppResource(ResourceIdentifier id)
        {
            ContainerAppResource.ValidateResourceId(id);
            return new ContainerAppResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppDetectorPropertyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppDetectorPropertyResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppDetectorPropertyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppDetectorPropertyResource"/> object. </returns>
        public virtual ContainerAppDetectorPropertyResource GetContainerAppDetectorPropertyResource(ResourceIdentifier id)
        {
            ContainerAppDetectorPropertyResource.ValidateResourceId(id);
            return new ContainerAppDetectorPropertyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppRevisionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppRevisionResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppRevisionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppRevisionResource"/> object. </returns>
        public virtual ContainerAppRevisionResource GetContainerAppRevisionResource(ResourceIdentifier id)
        {
            ContainerAppRevisionResource.ValidateResourceId(id);
            return new ContainerAppRevisionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppDetectorPropertyRevisionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppDetectorPropertyRevisionResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppDetectorPropertyRevisionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppDetectorPropertyRevisionResource"/> object. </returns>
        public virtual ContainerAppDetectorPropertyRevisionResource GetContainerAppDetectorPropertyRevisionResource(ResourceIdentifier id)
        {
            ContainerAppDetectorPropertyRevisionResource.ValidateResourceId(id);
            return new ContainerAppDetectorPropertyRevisionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppReplicaResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppReplicaResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppReplicaResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppReplicaResource"/> object. </returns>
        public virtual ContainerAppReplicaResource GetContainerAppReplicaResource(ResourceIdentifier id)
        {
            ContainerAppReplicaResource.ValidateResourceId(id);
            return new ContainerAppReplicaResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppDetectorResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppDetectorResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppDetectorResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppDetectorResource"/> object. </returns>
        public virtual ContainerAppDetectorResource GetContainerAppDetectorResource(ResourceIdentifier id)
        {
            ContainerAppDetectorResource.ValidateResourceId(id);
            return new ContainerAppDetectorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppManagedEnvironmentDetectorResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppManagedEnvironmentDetectorResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppManagedEnvironmentDetectorResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppManagedEnvironmentDetectorResource"/> object. </returns>
        public virtual ContainerAppManagedEnvironmentDetectorResource GetContainerAppManagedEnvironmentDetectorResource(ResourceIdentifier id)
        {
            ContainerAppManagedEnvironmentDetectorResource.ValidateResourceId(id);
            return new ContainerAppManagedEnvironmentDetectorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppJobDetectorResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppJobDetectorResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppJobDetectorResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppJobDetectorResource"/> object. </returns>
        public virtual ContainerAppJobDetectorResource GetContainerAppJobDetectorResource(ResourceIdentifier id)
        {
            ContainerAppJobDetectorResource.ValidateResourceId(id);
            return new ContainerAppJobDetectorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource"/> object. </returns>
        public virtual ContainerAppManagedEnvironmentDetectorResourcePropertyResource GetContainerAppManagedEnvironmentDetectorResourcePropertyResource(ResourceIdentifier id)
        {
            ContainerAppManagedEnvironmentDetectorResourcePropertyResource.ValidateResourceId(id);
            return new ContainerAppManagedEnvironmentDetectorResourcePropertyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppManagedEnvironmentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppManagedEnvironmentResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppManagedEnvironmentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppManagedEnvironmentResource"/> object. </returns>
        public virtual ContainerAppManagedEnvironmentResource GetContainerAppManagedEnvironmentResource(ResourceIdentifier id)
        {
            ContainerAppManagedEnvironmentResource.ValidateResourceId(id);
            return new ContainerAppManagedEnvironmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppJobDetectorPropertyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppJobDetectorPropertyResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppJobDetectorPropertyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppJobDetectorPropertyResource"/> object. </returns>
        public virtual ContainerAppJobDetectorPropertyResource GetContainerAppJobDetectorPropertyResource(ResourceIdentifier id)
        {
            ContainerAppJobDetectorPropertyResource.ValidateResourceId(id);
            return new ContainerAppJobDetectorPropertyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppJobResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppJobResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppJobResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppJobResource"/> object. </returns>
        public virtual ContainerAppJobResource GetContainerAppJobResource(ResourceIdentifier id)
        {
            ContainerAppJobResource.ValidateResourceId(id);
            return new ContainerAppJobResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="JavaComponentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="JavaComponentResource.CreateResourceIdentifier" /> to create a <see cref="JavaComponentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JavaComponentResource"/> object. </returns>
        public virtual JavaComponentResource GetJavaComponentResource(ResourceIdentifier id)
        {
            JavaComponentResource.ValidateResourceId(id);
            return new JavaComponentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppJobExecutionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppJobExecutionResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppJobExecutionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppJobExecutionResource"/> object. </returns>
        public virtual ContainerAppJobExecutionResource GetContainerAppJobExecutionResource(ResourceIdentifier id)
        {
            ContainerAppJobExecutionResource.ValidateResourceId(id);
            return new ContainerAppJobExecutionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppManagedCertificateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppManagedCertificateResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppManagedCertificateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppManagedCertificateResource"/> object. </returns>
        public virtual ContainerAppManagedCertificateResource GetContainerAppManagedCertificateResource(ResourceIdentifier id)
        {
            ContainerAppManagedCertificateResource.ValidateResourceId(id);
            return new ContainerAppManagedCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppManagedEnvironmentStorageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppManagedEnvironmentStorageResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppManagedEnvironmentStorageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppManagedEnvironmentStorageResource"/> object. </returns>
        public virtual ContainerAppManagedEnvironmentStorageResource GetContainerAppManagedEnvironmentStorageResource(ResourceIdentifier id)
        {
            ContainerAppManagedEnvironmentStorageResource.ValidateResourceId(id);
            return new ContainerAppManagedEnvironmentStorageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SessionPoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SessionPoolResource.CreateResourceIdentifier" /> to create a <see cref="SessionPoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SessionPoolResource"/> object. </returns>
        public virtual SessionPoolResource GetSessionPoolResource(ResourceIdentifier id)
        {
            SessionPoolResource.ValidateResourceId(id);
            return new SessionPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppSourceControlResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppSourceControlResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppSourceControlResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppSourceControlResource"/> object. </returns>
        public virtual ContainerAppSourceControlResource GetContainerAppSourceControlResource(ResourceIdentifier id)
        {
            ContainerAppSourceControlResource.ValidateResourceId(id);
            return new ContainerAppSourceControlResource(Client, id);
        }
    }
}
