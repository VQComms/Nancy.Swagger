using System.Collections.Generic;
using JetBrains.Annotations;
using Nancy.Swagger.Attributes;

namespace Nancy.Swagger.ResourceListing
{
    /// <summary>
    /// The Authorization object provides information about a specific authorization scheme.
    /// </summary>
    /// <example>
    /// <code>
    /// "oauth2": {
    ///   "type": "oauth2",
    ///   "scopes": [
    ///     {
    ///       "scope": "email",
    ///       "description": "Access to your email address"
    ///     },
    ///     {
    ///       "scope": "pets",
    ///       "description": "Access to your pets"
    ///     }
    ///   ],
    ///   "grantTypes": {
    ///     "implicit": {
    ///       "loginEndpoint": {
    ///         "url": "http://petstore.swagger.wordnik.com/oauth/dialog"
    ///       },
    ///       "tokenName": "access_token"
    ///     },
    ///     "authorization_code": {
    ///       "tokenRequestEndpoint": {
    ///         "url": "http://petstore.swagger.wordnik.com/oauth/requestToken",
    ///         "clientIdName": "client_id",
    ///         "clientSecretName": "client_secret"
    ///       },
    ///       "tokenEndpoint": {
    ///         "url": "http://petstore.swagger.wordnik.com/oauth/token",
    ///         "tokenName": "access_code"
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </example>
    [PublicAPI]
    public class Authorization
    {
        /// <summary>
        /// The type of the authorization scheme.
        /// </summary>
        [Required]
        public AuthorizationType Type { get; set; }

        /// <summary>
        /// Denotes how the API key must be passed.
        /// </summary>
        [Required]
        public PassType PassAs { get; set; }

        /// <summary>
        /// The name of the header or query parameter to be used when passing the API key.
        /// </summary>
        [Required]
        public string Keyname { get; set; }

        /// <summary>
        /// A list of supported OAuth2 scopes.
        /// </summary>
        public IEnumerable<OAuth2Scope> Scopes { get; set; }

        /// <summary>
        /// Detailed information about the grant types supported by the oauth2 authorization scheme.
        /// </summary>
        [Required]
        public GrantTypes GrantTypes { get; set; }
    }
}