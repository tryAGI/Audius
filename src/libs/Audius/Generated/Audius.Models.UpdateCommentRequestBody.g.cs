
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCommentRequestBody
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
        /// The updated comment text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Array of user IDs mentioned in the comment (max 10)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        public global::System.Collections.Generic.IList<int>? Mentions { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCommentRequestBody" /> class.
        /// </summary>
        /// <param name="entityType">
        /// Example: Track
        /// </param>
        /// <param name="entityId">
        /// ID of the entity being commented on<br/>
        /// Example: 12345
        /// </param>
        /// <param name="body">
        /// The updated comment text
        /// </param>
        /// <param name="mentions">
        /// Array of user IDs mentioned in the comment (max 10)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCommentRequestBody(
            global::Audius.CommentEntityType entityType,
            int entityId,
            string body,
            global::System.Collections.Generic.IList<int>? mentions)
        {
            this.EntityType = entityType;
            this.EntityId = entityId;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Mentions = mentions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCommentRequestBody" /> class.
        /// </summary>
        public UpdateCommentRequestBody()
        {
        }

    }
}