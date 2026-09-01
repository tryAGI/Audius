
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Tip
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.User Sender { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiver")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.User Receiver { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Slot { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followee_supporters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.SupporterReference> FolloweeSupporters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tx_signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TxSignature { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tip" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        /// <param name="createdAt"></param>
        /// <param name="slot"></param>
        /// <param name="followeeSupporters"></param>
        /// <param name="txSignature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Tip(
            string amount,
            global::Audius.User sender,
            global::Audius.User receiver,
            string createdAt,
            int slot,
            global::System.Collections.Generic.IList<global::Audius.SupporterReference> followeeSupporters,
            string txSignature)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Receiver = receiver ?? throw new global::System.ArgumentNullException(nameof(receiver));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Slot = slot;
            this.FolloweeSupporters = followeeSupporters ?? throw new global::System.ArgumentNullException(nameof(followeeSupporters));
            this.TxSignature = txSignature ?? throw new global::System.ArgumentNullException(nameof(txSignature));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tip" /> class.
        /// </summary>
        public Tip()
        {
        }

    }
}