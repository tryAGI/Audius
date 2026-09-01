
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeactivateAccessKeyRequestBody
    {
        /// <summary>
        /// The bearer token (API access key) to deactivate
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
        /// Initializes a new instance of the <see cref="DeactivateAccessKeyRequestBody" /> class.
        /// </summary>
        /// <param name="apiAccessKey">
        /// The bearer token (API access key) to deactivate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeactivateAccessKeyRequestBody(
            string apiAccessKey)
        {
            this.ApiAccessKey = apiAccessKey ?? throw new global::System.ArgumentNullException(nameof(apiAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateAccessKeyRequestBody" /> class.
        /// </summary>
        public DeactivateAccessKeyRequestBody()
        {
        }

    }
}