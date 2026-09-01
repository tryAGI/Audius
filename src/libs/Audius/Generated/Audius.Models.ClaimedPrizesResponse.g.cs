
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClaimedPrizesResponse
    {
        /// <summary>
        /// List of claimed prizes for the wallet (action_data excluded for security)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.ClaimedPrize> Data { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimedPrizesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of claimed prizes for the wallet (action_data excluded for security)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClaimedPrizesResponse(
            global::System.Collections.Generic.IList<global::Audius.ClaimedPrize> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimedPrizesResponse" /> class.
        /// </summary>
        public ClaimedPrizesResponse()
        {
        }

    }
}