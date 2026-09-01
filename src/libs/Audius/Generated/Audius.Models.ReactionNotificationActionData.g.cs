
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReactionNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reacted_to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReactedTo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReactionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reaction_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReactionValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiver_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReceiverUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderWallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tip_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TipAmount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionNotificationActionData" /> class.
        /// </summary>
        /// <param name="reactedTo"></param>
        /// <param name="reactionType"></param>
        /// <param name="reactionValue"></param>
        /// <param name="receiverUserId"></param>
        /// <param name="senderUserId"></param>
        /// <param name="senderWallet"></param>
        /// <param name="tipAmount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReactionNotificationActionData(
            string reactedTo,
            string reactionType,
            int reactionValue,
            string receiverUserId,
            string senderUserId,
            string senderWallet,
            string tipAmount)
        {
            this.ReactedTo = reactedTo ?? throw new global::System.ArgumentNullException(nameof(reactedTo));
            this.ReactionType = reactionType ?? throw new global::System.ArgumentNullException(nameof(reactionType));
            this.ReactionValue = reactionValue;
            this.ReceiverUserId = receiverUserId ?? throw new global::System.ArgumentNullException(nameof(receiverUserId));
            this.SenderUserId = senderUserId ?? throw new global::System.ArgumentNullException(nameof(senderUserId));
            this.SenderWallet = senderWallet ?? throw new global::System.ArgumentNullException(nameof(senderWallet));
            this.TipAmount = tipAmount ?? throw new global::System.ArgumentNullException(nameof(tipAmount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionNotificationActionData" /> class.
        /// </summary>
        public ReactionNotificationActionData()
        {
        }

    }
}