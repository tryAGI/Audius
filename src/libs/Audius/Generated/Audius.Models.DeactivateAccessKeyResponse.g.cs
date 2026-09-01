
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeactivateAccessKeyResponse
    {
        /// <summary>
        /// Whether the deactivation was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateAccessKeyResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the deactivation was successful
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeactivateAccessKeyResponse(
            bool? success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateAccessKeyResponse" /> class.
        /// </summary>
        public DeactivateAccessKeyResponse()
        {
        }

    }
}