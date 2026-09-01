
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegisterApiKeyResponse
    {
        /// <summary>
        /// Whether the registration was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterApiKeyResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the registration was successful
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterApiKeyResponse(
            bool? success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterApiKeyResponse" /> class.
        /// </summary>
        public RegisterApiKeyResponse()
        {
        }

    }
}