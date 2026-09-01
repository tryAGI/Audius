
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RewardCodeErrorResponse
    {
        /// <summary>
        /// Error message indicating why the code cannot be redeemed<br/>
        /// Example: used
        /// </summary>
        /// <example>used</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.RewardCodeErrorResponseErrorJsonConverter))]
        public global::Audius.RewardCodeErrorResponseError? Error { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RewardCodeErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error message indicating why the code cannot be redeemed<br/>
        /// Example: used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RewardCodeErrorResponse(
            global::Audius.RewardCodeErrorResponseError? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RewardCodeErrorResponse" /> class.
        /// </summary>
        public RewardCodeErrorResponse()
        {
        }

    }
}