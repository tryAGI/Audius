
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReplyComment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// Type of entity that can be commented on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.CommentEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.CommentEntityType EntityType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        public global::System.Collections.Generic.IList<global::Audius.CommentMention>? Mentions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_timestamp_s")]
        public int? TrackTimestampS { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("react_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReactCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_edited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEdited { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_current_user_reacted")]
        public bool? IsCurrentUserReacted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_artist_reacted")]
        public bool? IsArtistReacted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Optional URL for a video attachment on this reply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_comment_id")]
        public int? ParentCommentId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyComment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityId"></param>
        /// <param name="entityType">
        /// Type of entity that can be commented on
        /// </param>
        /// <param name="userId"></param>
        /// <param name="message"></param>
        /// <param name="reactCount"></param>
        /// <param name="isEdited"></param>
        /// <param name="createdAt"></param>
        /// <param name="mentions"></param>
        /// <param name="trackTimestampS"></param>
        /// <param name="isCurrentUserReacted"></param>
        /// <param name="isArtistReacted"></param>
        /// <param name="updatedAt"></param>
        /// <param name="videoUrl">
        /// Optional URL for a video attachment on this reply
        /// </param>
        /// <param name="parentCommentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplyComment(
            string id,
            string entityId,
            global::Audius.CommentEntityType entityType,
            string userId,
            string message,
            int reactCount,
            bool isEdited,
            string createdAt,
            global::System.Collections.Generic.IList<global::Audius.CommentMention>? mentions,
            int? trackTimestampS,
            bool? isCurrentUserReacted,
            bool? isArtistReacted,
            string? updatedAt,
            string? videoUrl,
            int? parentCommentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.EntityType = entityType;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Mentions = mentions;
            this.TrackTimestampS = trackTimestampS;
            this.ReactCount = reactCount;
            this.IsEdited = isEdited;
            this.IsCurrentUserReacted = isCurrentUserReacted;
            this.IsArtistReacted = isArtistReacted;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt;
            this.VideoUrl = videoUrl;
            this.ParentCommentId = parentCommentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyComment" /> class.
        /// </summary>
        public ReplyComment()
        {
        }

    }
}