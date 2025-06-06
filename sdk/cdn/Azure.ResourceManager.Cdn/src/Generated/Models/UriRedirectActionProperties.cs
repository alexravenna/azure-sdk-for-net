// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Defines the parameters for the url redirect action.
    /// Serialized Name: UrlRedirectActionParameters
    /// </summary>
    public partial class UriRedirectActionProperties : DeliveryRuleActionProperties
    {
        /// <summary> Initializes a new instance of <see cref="UriRedirectActionProperties"/>. </summary>
        /// <param name="redirectType">
        /// The redirect type the rule will use when redirecting traffic.
        /// Serialized Name: UrlRedirectActionParameters.redirectType
        /// </param>
        public UriRedirectActionProperties(RedirectType redirectType)
        {
            RedirectType = redirectType;
            TypeName = DeliveryRuleActionParametersType.DeliveryRuleUriRedirectActionParameters;
        }

        /// <summary> Initializes a new instance of <see cref="UriRedirectActionProperties"/>. </summary>
        /// <param name="typeName"> Serialized Name: DeliveryRuleActionParameters.typeName. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="redirectType">
        /// The redirect type the rule will use when redirecting traffic.
        /// Serialized Name: UrlRedirectActionParameters.redirectType
        /// </param>
        /// <param name="destinationProtocol">
        /// Protocol to use for the redirect. The default value is MatchRequest
        /// Serialized Name: UrlRedirectActionParameters.destinationProtocol
        /// </param>
        /// <param name="customPath">
        /// The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination path.
        /// Serialized Name: UrlRedirectActionParameters.customPath
        /// </param>
        /// <param name="customHostname">
        /// Host to redirect. Leave empty to use the incoming host as the destination host.
        /// Serialized Name: UrlRedirectActionParameters.customHostname
        /// </param>
        /// <param name="customQueryString">
        /// The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string; leave empty to preserve the incoming query string. Query string must be in &lt;key&gt;=&lt;value&gt; format. ? and &amp; will be added automatically so do not include them.
        /// Serialized Name: UrlRedirectActionParameters.customQueryString
        /// </param>
        /// <param name="customFragment">
        /// Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.
        /// Serialized Name: UrlRedirectActionParameters.customFragment
        /// </param>
        internal UriRedirectActionProperties(DeliveryRuleActionParametersType typeName, IDictionary<string, BinaryData> serializedAdditionalRawData, RedirectType redirectType, DestinationProtocol? destinationProtocol, string customPath, string customHostname, string customQueryString, string customFragment) : base(typeName, serializedAdditionalRawData)
        {
            RedirectType = redirectType;
            DestinationProtocol = destinationProtocol;
            CustomPath = customPath;
            CustomHostname = customHostname;
            CustomQueryString = customQueryString;
            CustomFragment = customFragment;
            TypeName = typeName;
        }

        /// <summary> Initializes a new instance of <see cref="UriRedirectActionProperties"/> for deserialization. </summary>
        internal UriRedirectActionProperties()
        {
        }

        /// <summary>
        /// The redirect type the rule will use when redirecting traffic.
        /// Serialized Name: UrlRedirectActionParameters.redirectType
        /// </summary>
        public RedirectType RedirectType { get; set; }
        /// <summary>
        /// Protocol to use for the redirect. The default value is MatchRequest
        /// Serialized Name: UrlRedirectActionParameters.destinationProtocol
        /// </summary>
        public DestinationProtocol? DestinationProtocol { get; set; }
        /// <summary>
        /// The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination path.
        /// Serialized Name: UrlRedirectActionParameters.customPath
        /// </summary>
        public string CustomPath { get; set; }
        /// <summary>
        /// Host to redirect. Leave empty to use the incoming host as the destination host.
        /// Serialized Name: UrlRedirectActionParameters.customHostname
        /// </summary>
        public string CustomHostname { get; set; }
        /// <summary>
        /// The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string; leave empty to preserve the incoming query string. Query string must be in &lt;key&gt;=&lt;value&gt; format. ? and &amp; will be added automatically so do not include them.
        /// Serialized Name: UrlRedirectActionParameters.customQueryString
        /// </summary>
        public string CustomQueryString { get; set; }
        /// <summary>
        /// Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.
        /// Serialized Name: UrlRedirectActionParameters.customFragment
        /// </summary>
        public string CustomFragment { get; set; }
    }
}
