
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TipGate
    {
        /// <summary>
        /// Must tip the given user ID to unlock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tip_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TipUserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TipGate" /> class.
        /// </summary>
        /// <param name="tipUserId">
        /// Must tip the given user ID to unlock
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TipGate(
            int tipUserId)
        {
            this.TipUserId = tipUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TipGate" /> class.
        /// </summary>
        public TipGate()
        {
        }

    }
}