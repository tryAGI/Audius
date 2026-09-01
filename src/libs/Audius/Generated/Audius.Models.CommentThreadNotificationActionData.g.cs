
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommentThreadNotificationActionData
    {
        /// <summary>
        /// Example: Track
        /// </summary>
        /// <example>Track</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.CommentThreadNotificationActionDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.CommentThreadNotificationActionDataType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_id")]
        public string? CommentId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentThreadNotificationActionData" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: Track
        /// </param>
        /// <param name="entityId"></param>
        /// <param name="entityUserId"></param>
        /// <param name="commentUserId"></param>
        /// <param name="commentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommentThreadNotificationActionData(
            global::Audius.CommentThreadNotificationActionDataType type,
            string entityId,
            string entityUserId,
            string commentUserId,
            string? commentId)
        {
            this.Type = type;
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.EntityUserId = entityUserId ?? throw new global::System.ArgumentNullException(nameof(entityUserId));
            this.CommentUserId = commentUserId ?? throw new global::System.ArgumentNullException(nameof(commentUserId));
            this.CommentId = commentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentThreadNotificationActionData" /> class.
        /// </summary>
        public CommentThreadNotificationActionData()
        {
        }

    }
}