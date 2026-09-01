
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegisterApiKeyRequestBody
    {
        /// <summary>
        /// The API secret (private key hex) for the developer app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiSecret { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterApiKeyRequestBody" /> class.
        /// </summary>
        /// <param name="apiSecret">
        /// The API secret (private key hex) for the developer app
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterApiKeyRequestBody(
            string apiSecret)
        {
            this.ApiSecret = apiSecret ?? throw new global::System.ArgumentNullException(nameof(apiSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterApiKeyRequestBody" /> class.
        /// </summary>
        public RegisterApiKeyRequestBody()
        {
        }

    }
}