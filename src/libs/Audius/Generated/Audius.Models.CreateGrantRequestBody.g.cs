
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGrantRequestBody
    {
        /// <summary>
        /// The developer app address (API key) to grant authorization to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppApiKey { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGrantRequestBody" /> class.
        /// </summary>
        /// <param name="appApiKey">
        /// The developer app address (API key) to grant authorization to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGrantRequestBody(
            string appApiKey)
        {
            this.AppApiKey = appApiKey ?? throw new global::System.ArgumentNullException(nameof(appApiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGrantRequestBody" /> class.
        /// </summary>
        public CreateGrantRequestBody()
        {
        }

    }
}