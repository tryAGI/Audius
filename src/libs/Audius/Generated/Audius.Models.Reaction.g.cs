
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Reaction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReactionValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReactionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reacted_to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReactedTo { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reaction" /> class.
        /// </summary>
        /// <param name="reactionValue"></param>
        /// <param name="reactionType"></param>
        /// <param name="senderUserId"></param>
        /// <param name="reactedTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Reaction(
            string reactionValue,
            string reactionType,
            string senderUserId,
            string reactedTo)
        {
            this.ReactionValue = reactionValue ?? throw new global::System.ArgumentNullException(nameof(reactionValue));
            this.ReactionType = reactionType ?? throw new global::System.ArgumentNullException(nameof(reactionType));
            this.SenderUserId = senderUserId ?? throw new global::System.ArgumentNullException(nameof(senderUserId));
            this.ReactedTo = reactedTo ?? throw new global::System.ArgumentNullException(nameof(reactedTo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reaction" /> class.
        /// </summary>
        public Reaction()
        {
        }

    }
}