
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommentMentionNotification
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_seen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSeen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seen_at")]
        public int? SeenAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.CommentMentionNotificationAction> Actions { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentMentionNotification" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="groupId"></param>
        /// <param name="isSeen"></param>
        /// <param name="actions"></param>
        /// <param name="seenAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommentMentionNotification(
            string type,
            string groupId,
            bool isSeen,
            global::System.Collections.Generic.IList<global::Audius.CommentMentionNotificationAction> actions,
            int? seenAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.IsSeen = isSeen;
            this.SeenAt = seenAt;
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentMentionNotification" /> class.
        /// </summary>
        public CommentMentionNotification()
        {
        }

    }
}