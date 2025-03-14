// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> File system linked service. </summary>
    public partial class FileServerLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="FileServerLinkedService"/>. </summary>
        /// <param name="host"> Host name of the server. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public FileServerLinkedService(object host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            Type = "FileServer";
        }

        /// <summary> Initializes a new instance of <see cref="FileServerLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> Host name of the server. Type: string (or Expression with resultType string). </param>
        /// <param name="userId"> User ID to logon the server. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password to logon the server.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal FileServerLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, object userId, SecretBase password, object encryptedCredential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            UserId = userId;
            Password = password;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "FileServer";
        }

        /// <summary> Host name of the server. Type: string (or Expression with resultType string). </summary>
        public object Host { get; set; }
        /// <summary> User ID to logon the server. Type: string (or Expression with resultType string). </summary>
        public object UserId { get; set; }
        /// <summary>
        /// Password to logon the server.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
