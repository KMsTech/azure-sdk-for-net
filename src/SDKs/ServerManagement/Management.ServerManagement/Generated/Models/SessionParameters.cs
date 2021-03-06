// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System.Linq;

    /// <summary>
    /// parameter collection for creation and other operations on sessions
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SessionParameters
    {
        /// <summary>
        /// Initializes a new instance of the SessionParameters class.
        /// </summary>
        public SessionParameters() { }

        /// <summary>
        /// Initializes a new instance of the SessionParameters class.
        /// </summary>
        /// <param name="userName">encrypted User name to be used to connect
        /// to node</param>
        /// <param name="password">encrypted Password associated with user
        /// name</param>
        /// <param name="retentionPeriod">session retention period. Possible
        /// values include: 'Session', 'Persistent'</param>
        /// <param name="credentialDataFormat">credential data format.
        /// Possible values include: 'RsaEncrypted'</param>
        /// <param name="encryptionCertificateThumbprint">encryption
        /// certificate thumbprint</param>
        public SessionParameters(string userName = default(string), string password = default(string), RetentionPeriod? retentionPeriod = default(RetentionPeriod?), CredentialDataFormat? credentialDataFormat = default(CredentialDataFormat?), string encryptionCertificateThumbprint = default(string))
        {
            UserName = userName;
            Password = password;
            RetentionPeriod = retentionPeriod;
            CredentialDataFormat = credentialDataFormat;
            EncryptionCertificateThumbprint = encryptionCertificateThumbprint;
        }

        /// <summary>
        /// Gets or sets encrypted User name to be used to connect to node
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets encrypted Password associated with user name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets session retention period. Possible values include:
        /// 'Session', 'Persistent'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.retentionPeriod")]
        public RetentionPeriod? RetentionPeriod { get; set; }

        /// <summary>
        /// Gets or sets credential data format. Possible values include:
        /// 'RsaEncrypted'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.credentialDataFormat")]
        public CredentialDataFormat? CredentialDataFormat { get; set; }

        /// <summary>
        /// Gets or sets encryption certificate thumbprint
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.EncryptionCertificateThumbprint")]
        public string EncryptionCertificateThumbprint { get; set; }

    }
}
