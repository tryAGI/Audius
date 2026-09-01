
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SupporterDethronedNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dethroned_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DethronedUserId { get; set; }

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
        /// Initializes a new instance of the <see cref="SupporterDethronedNotificationActionData" /> class.
        /// </summary>
        /// <param name="dethronedUserId"></param>
        /// <param name="senderUserId"></param>
        /// <param name="receiverUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupporterDethronedNotificationActionData(
            string dethronedUserId,
            string senderUserId,
            string receiverUserId)
        {
            this.DethronedUserId = dethronedUserId ?? throw new global::System.ArgumentNullException(nameof(dethronedUserId));
            this.SenderUserId = senderUserId ?? throw new global::System.ArgumentNullException(nameof(senderUserId));
            this.ReceiverUserId = receiverUserId ?? throw new global::System.ArgumentNullException(nameof(receiverUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupporterDethronedNotificationActionData" /> class.
        /// </summary>
        public SupporterDethronedNotificationActionData()
        {
        }

    }
}