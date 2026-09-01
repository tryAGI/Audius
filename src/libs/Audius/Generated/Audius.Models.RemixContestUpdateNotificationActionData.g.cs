
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemixContestUpdateNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixContestUpdateNotificationActionData" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="entityId"></param>
        /// <param name="entityUserId"></param>
        /// <param name="commentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixContestUpdateNotificationActionData(
            string eventId,
            string entityId,
            string entityUserId,
            string commentId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.EntityUserId = entityUserId ?? throw new global::System.ArgumentNullException(nameof(entityUserId));
            this.CommentId = commentId ?? throw new global::System.ArgumentNullException(nameof(commentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixContestUpdateNotificationActionData" /> class.
        /// </summary>
        public RemixContestUpdateNotificationActionData()
        {
        }

    }
}