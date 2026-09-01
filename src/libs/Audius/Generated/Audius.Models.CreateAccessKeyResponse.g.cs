
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAccessKeyResponse
    {
        /// <summary>
        /// The newly created bearer token (API access key)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiAccessKey { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessKeyResponse" /> class.
        /// </summary>
        /// <param name="apiAccessKey">
        /// The newly created bearer token (API access key)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessKeyResponse(
            string apiAccessKey)
        {
            this.ApiAccessKey = apiAccessKey ?? throw new global::System.ArgumentNullException(nameof(apiAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessKeyResponse" /> class.
        /// </summary>
        public CreateAccessKeyResponse()
        {
        }

    }
}