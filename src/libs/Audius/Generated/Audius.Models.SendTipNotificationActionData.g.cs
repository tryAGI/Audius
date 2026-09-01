
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SendTipNotificationActionData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SenderUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiver_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReceiverUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tip_tx_signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TipTxSignature { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendTipNotificationActionData" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="senderUserId"></param>
        /// <param name="receiverUserId"></param>
        /// <param name="tipTxSignature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendTipNotificationActionData(
            string amount,
            string senderUserId,
            string receiverUserId,
            string tipTxSignature)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.SenderUserId = senderUserId ?? throw new global::System.ArgumentNullException(nameof(senderUserId));
            this.ReceiverUserId = receiverUserId ?? throw new global::System.ArgumentNullException(nameof(receiverUserId));
            this.TipTxSignature = tipTxSignature ?? throw new global::System.ArgumentNullException(nameof(tipTxSignature));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendTipNotificationActionData" /> class.
        /// </summary>
        public SendTipNotificationActionData()
        {
        }

    }
}