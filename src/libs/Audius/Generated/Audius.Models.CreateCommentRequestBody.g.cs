
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCommentRequestBody
    {
        /// <summary>
        /// Example: Track
        /// </summary>
        /// <example>Track</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.CommentEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.CommentEntityType EntityType { get; set; }

        /// <summary>
        /// ID of the entity being commented on<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EntityId { get; set; }

        /// <summary>
        /// Comment text<br/>
        /// Example: Great track!
        /// </summary>
        /// <example>Great track!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Optional ID for the comment (will be generated if not provided)<br/>
        /// Example: 98765
        /// </summary>
        /// <example>98765</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commentId")]
        public int? CommentId { get; set; }

        /// <summary>
        /// Parent comment ID if this is a reply<br/>
        /// Example: 54321
        /// </summary>
        /// <example>54321</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public int? ParentId { get; set; }

        /// <summary>
        /// Timestamp in the track where the comment was made (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trackTimestampS")]
        public int? TrackTimestampS { get; set; }

        /// <summary>
        /// Array of user IDs mentioned in the comment (max 10)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        public global::System.Collections.Generic.IList<int>? Mentions { get; set; }

        /// <summary>
        /// Optional URL for a video attachment (stored on the comment record)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUrl")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommentRequestBody" /> class.
        /// </summary>
        /// <param name="entityType">
        /// Example: Track
        /// </param>
        /// <param name="entityId">
        /// ID of the entity being commented on<br/>
        /// Example: 12345
        /// </param>
        /// <param name="body">
        /// Comment text<br/>
        /// Example: Great track!
        /// </param>
        /// <param name="commentId">
        /// Optional ID for the comment (will be generated if not provided)<br/>
        /// Example: 98765
        /// </param>
        /// <param name="parentId">
        /// Parent comment ID if this is a reply<br/>
        /// Example: 54321
        /// </param>
        /// <param name="trackTimestampS">
        /// Timestamp in the track where the comment was made (in seconds)
        /// </param>
        /// <param name="mentions">
        /// Array of user IDs mentioned in the comment (max 10)
        /// </param>
        /// <param name="videoUrl">
        /// Optional URL for a video attachment (stored on the comment record)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCommentRequestBody(
            global::Audius.CommentEntityType entityType,
            int entityId,
            string body,
            int? commentId,
            int? parentId,
            int? trackTimestampS,
            global::System.Collections.Generic.IList<int>? mentions,
            string? videoUrl)
        {
            this.EntityType = entityType;
            this.EntityId = entityId;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CommentId = commentId;
            this.ParentId = parentId;
            this.TrackTimestampS = trackTimestampS;
            this.Mentions = mentions;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommentRequestBody" /> class.
        /// </summary>
        public CreateCommentRequestBody()
        {
        }

    }
}