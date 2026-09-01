
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BestSellingItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentId { get; set; }

        /// <summary>
        /// Example: track
        /// </summary>
        /// <example>track</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.BestSellingItemContentTypeJsonConverter))]
        public global::Audius.BestSellingItemContentType? ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BestSellingItem" /> class.
        /// </summary>
        /// <param name="contentId"></param>
        /// <param name="title"></param>
        /// <param name="ownerId"></param>
        /// <param name="contentType">
        /// Example: track
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BestSellingItem(
            string contentId,
            string title,
            string ownerId,
            global::Audius.BestSellingItemContentType? contentType)
        {
            this.ContentId = contentId ?? throw new global::System.ArgumentNullException(nameof(contentId));
            this.ContentType = contentType;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BestSellingItem" /> class.
        /// </summary>
        public BestSellingItem()
        {
        }

    }
}