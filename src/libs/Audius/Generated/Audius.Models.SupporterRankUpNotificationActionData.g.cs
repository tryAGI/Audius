
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SupporterRankUpNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

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
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupporterRankUpNotificationActionData" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="senderUserId"></param>
        /// <param name="receiverUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupporterRankUpNotificationActionData(
            int rank,
            string senderUserId,
            string receiverUserId)
        {
            this.Rank = rank;
            this.SenderUserId = senderUserId ?? throw new global::System.ArgumentNullException(nameof(senderUserId));
            this.ReceiverUserId = receiverUserId ?? throw new global::System.ArgumentNullException(nameof(receiverUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupporterRankUpNotificationActionData" /> class.
        /// </summary>
        public SupporterRankUpNotificationActionData()
        {
        }

    }
}