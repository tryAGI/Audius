
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReactCommentRequestBody
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
        /// ID of the entity (track) being commented on<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EntityId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactCommentRequestBody" /> class.
        /// </summary>
        /// <param name="entityType">
        /// Example: Track
        /// </param>
        /// <param name="entityId">
        /// ID of the entity (track) being commented on<br/>
        /// Example: 12345
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReactCommentRequestBody(
            global::Audius.CommentEntityType entityType,
            int entityId)
        {
            this.EntityType = entityType;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactCommentRequestBody" /> class.
        /// </summary>
        public ReactCommentRequestBody()
        {
        }

    }
}